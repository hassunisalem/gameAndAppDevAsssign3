using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePoints : MonoBehaviour
{
    public float smoothing = 5f;
    public Transform target;


    void Start()
    {
        StartCoroutine(MyCoroutine(target));
    }


    IEnumerator MyCoroutine(Transform target)
    {
        while (Vector3.Distance(transform.position, target.position) > 0.05f)
        {
            
            transform.position = Vector3.MoveTowards(transform.position, target.position, smoothing);
            yield return new WaitForSeconds(0.1f);
        
        }

        print("Reached the target.");

        yield return new WaitForSeconds(3f);

        print("MyCoroutine is now finished.");
    }
}
