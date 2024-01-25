using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3Script : MonoBehaviour
{
    // Start is called before the first frame update
    public int pay;
    void Start()
    {
        int b = pay/100;
        int c = (pay-b*100)/50;
        int d = (pay-b*100-c*50)/20;
        int e = (pay-b*100-c*50-d*20)/10;
        int f = (pay-b*100-c*50-d*20-e*10)/5;
        int g = (pay-b*100-c*50-d*20-e*10-f*5)/1;
        Debug.Log("Task 3: # of $100 bills is"+b);
        Debug.Log("Task 3: # of $50 bills is"+c);
        Debug.Log("Task 3: # of $20 bills is"+d);
        Debug.Log("Task 3: # of $10 bills is"+e);
        Debug.Log("Task 3: # of $5 bills is"+f);
        Debug.Log("Task 3: # of $1 bills is"+g);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
