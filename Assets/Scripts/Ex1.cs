using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    private Vector3 target = new Vector3(4,2,5);

    private float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 x = target - transform.position;
        Vector3 dir = x.normalized;
        float dis = x.magnitude;
        if (dis > 1)
        {
            transform.position += dir * speed * Time.deltaTime;
        }
    }
}
