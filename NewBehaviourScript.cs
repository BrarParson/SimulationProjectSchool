using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{

    public Rigidbody rb;
    public SphereCollider sphereCollider;
    void OnMouseDown()
    {
        rb = GetComponent<Rigidbody>();
        sphereCollider = GetComponent<SphereCollider>();
        rb.AddForce(-transform.forward * 500);
    }


}