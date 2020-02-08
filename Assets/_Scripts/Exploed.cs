using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploed : MonoBehaviour
{
    public GameObject bomb;
    public float power = 10.0f;
    public float redius = 5.0f;
    public float upForce = 1.0f;

    /*private void FixedUpdate()
    {
        if(bomb == enabled)
        {
            Invoke("Detonate",5);
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ColorBalls")
        {
            Invoke("Detonate", 0);
            Destroy(gameObject, 0.2f);
        }
    }
    void Detonate()
    {
        Vector3 explosionPos = bomb.transform.position;
        Collider[] coll = Physics.OverlapSphere(explosionPos, redius);
        foreach (Collider hit in coll)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(power, explosionPos, redius, upForce, ForceMode.Impulse);
            }
        }
    }
}
