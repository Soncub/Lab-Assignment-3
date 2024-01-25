using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2Script : MonoBehaviour
{
    // Start is called before the first frame update
    public float bookprice = 5;
    public float copies = 5;

    void Start()
    {
        float a = bookprice;
        float b = copies;

        float c = bookprice * copies * 0.6f + 3 + (0.75f *(copies-1));

        Debug.Log("the value of profit is:" + c);
    }

    // Update is called once per frame
    void Update()
    {
       
    
    }
}
