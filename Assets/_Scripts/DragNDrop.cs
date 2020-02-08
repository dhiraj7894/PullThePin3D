using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{

    public float moveSpeed;
    public bool isBeingHeld = false;

    // Update is called once per frame
    public void Update()
    {
        Vector3 dir = new Vector3(0, moveSpeed, 0);
        if (isBeingHeld == true)
        {
            transform.Translate(dir);
        }
        if (transform.position.x > 5f)
        {
            transform.position = new Vector3(5f, transform.position.y, 0);
        }
    }
    public void OnMouseDown()
    {
            isBeingHeld = true;
    }

}
