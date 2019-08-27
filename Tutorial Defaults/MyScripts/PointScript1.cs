using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript1 : MonoBehaviour
{
    public float count = 0;
    public Text counter;
   

    void OnTriggerEnter(Collider col)
    {
       
            
            print("ramt");
        count++;
            Destroy(col.gameObject);
        counter.text = "Count: " + count;
        
    }
}

