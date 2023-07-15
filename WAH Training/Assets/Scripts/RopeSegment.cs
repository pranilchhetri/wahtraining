using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSegment : MonoBehaviour
{
    public Rigidbody connectedBody;
    public float maxDistance = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if(connectedBody!= null){
            float distance = Vector3.Distance(transform.position, connectedBody.transform.position);

            if(distance >maxDistance){
                Vector3 force = (connectedBody.transform.position - transform.position).normalized * (distance - maxDistance);
                connectedBody.AddForce(-force);
            }
        }
    }
}
