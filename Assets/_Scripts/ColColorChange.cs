using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColColorChange : MonoBehaviour
{
    public Material[] materials;
    Renderer rend;

    private void Start()
    {
        
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        int i = Random.Range(1, 5);
        rend.sharedMaterial = materials[5];
    }
    private void OnCollisionEnter(Collision other)
    {
        int i = Random.Range(1, 5);
        if (other.gameObject.tag == "ColorBalls")
        {
            other.gameObject.tag = "ColorBalls";
            rend.sharedMaterial = materials[i];
        }
        if(other.gameObject.tag == "Untagged")
        {
            rend.sharedMaterial = materials[5];
        }
    }
}
