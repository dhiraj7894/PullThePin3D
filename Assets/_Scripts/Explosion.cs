using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float exp_delay = 1f;
    public float exp_rate = 1f;
    public float exp_max_size = 10f;
    public float exp_speed = 1f;
    public float cur_redius = 0f;

    bool exploded = false;

    CircleCollider2D exp_redius;

    // Start is called before the first frame update
    void Start()
    {
        exp_redius = gameObject.GetComponent<CircleCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (exp_delay == 0)
        {
            exploded = true;
        }
        
    }
    private void FixedUpdate()
    {
        if(exploded == true)
        {
            if (cur_redius < exp_max_size)
            {
                cur_redius += exp_rate;
            }
            else
            {
                Object.Destroy(this.gameObject.transform.parent.gameObject);
            }
            exp_redius.radius = cur_redius;

        }
    }
     void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "ColorBalls")
        {
            Debug.Log("Collision Active");
            exp_delay = 0f;
        }

        if(exploded == true)
        {
            if(col.GetComponent<Rigidbody2D>() != null)
            {
                Vector2 target = col.gameObject.transform.position;
                Vector2 bomb = gameObject.transform.position;

                Vector2 dir = 100f * (target - bomb);
                col.GetComponent<Rigidbody2D>().AddForce(dir);
            }
        }
    }

}
