using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{

    public Transform target;

    public Vector3 offset;
    Vector3 velocity = Vector3.zero;
    public float smoothTime = 0.3f;
    public GameObject ball;
    Vector3 pos;


    private void Start()
    {
         pos = transform.position;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desirePos = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desirePos, smoothTime * Time.deltaTime);
        if (ball.transform.parent == null)
        {
            transform.position = smoothPos;
        } else
        {
            transform.position = pos;
        }

    }
}
