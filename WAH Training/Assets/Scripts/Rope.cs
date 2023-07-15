using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] Transform startTransform, endTransform;
   [SerializeField] int segmentCount = 10;       // The number of segments in the rope.
    [SerializeField] float totalLength = 10;   // The spacing between each segment.
    [SerializeField] float totalWeight = 10;
    [SerializeField] float drag = 1;
    [SerializeField] float angularDrag = 1;   

    Transform[] segments;
    [SerializeField] Transform segmentParent;

    void Start()
    {
      segments = new Transform[segmentCount];
      GenerateSegments();
    }

   
    private void GenerateSegments() {
        Transform prevTransform = startTransform;
        Vector3 direction = (endTransform.position - startTransform.position);
        for (int i = 0; i<segmentCount; i++){
            GameObject segment = new GameObject($"segment_{i}");
            segment.transform.SetParent(segmentParent);

            Vector3 pos = prevTransform.position = (direction / segmentCount);
            segment.transform.position = pos;

            segments[i] = segment.transform;
            prevTransform = segment.transform;
        }
    }

    
}
 