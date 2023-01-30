using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    [SerializeField] private float radi = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        LayerMask mask = LayerMask.GetMask("PlayerMask");
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, radi, mask))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
