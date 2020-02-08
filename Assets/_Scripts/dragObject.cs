using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * 3,0,0);
    }
}
