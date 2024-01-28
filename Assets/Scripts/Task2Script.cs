using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2Script : MonoBehaviour
{
    // Start is called before the first frame update
    public float bookprice;
    public float copies;
    void Start()
    {
        float c = bookprice * copies * 0.6f + 3 + (0.75f *(copies-1));
        float d = bookprice * copies - c;
        Debug.Log("Task 2: the value of book cost is: "+c);
        Debug.Log("Task 2: the value of book profit is: "+d);
    }

    // Update is called once per frame
    void Update()
    {
       
    
    }
}
