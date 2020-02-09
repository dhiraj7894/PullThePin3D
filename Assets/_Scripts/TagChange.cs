using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagChange : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "UnColorBalls")
        {
            other.gameObject.tag = "ColorBalls";
        }
        
    }
}
