using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float damping;
    // Start is called before the first frame update
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        Vector3 movePosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
    }
}
