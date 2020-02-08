using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class DragDown : MonoBehaviour
{
    public int minimum;
    public int maximum;
    public int current;
    public Image Mask;

    public GameObject[] balls;

    private void Start()
    {
        maximum = balls.Length;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ColorBalls")
        {
            current++;
        }
        else if(other.tag == "UnColorBalls")
        {
            Destroy(other.gameObject);
        }        
    }
    private void Update()
    {
        GetCurrentFill();
        if (current >= maximum)
        {
            FindObjectOfType<GameManger>().setActiveEnd();
        }
        if (current < maximum && current > 15)
        {
            FindObjectOfType<GameManger>().setActiveRep();
            
        }

    }
    void GetCurrentFill()
    {
        float currentOffset = current - minimum;
        float maximumOffset = maximum - minimum;
        float fillAmount = currentOffset / maximumOffset;
        Mask.fillAmount = fillAmount;
    }

}
