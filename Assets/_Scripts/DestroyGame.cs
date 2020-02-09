using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Destory_balls")
        {
            FindObjectOfType<GameManger>().setActiveRep();
        }

    }

        
}
