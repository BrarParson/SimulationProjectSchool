using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetEverything : MonoBehaviour
{
    public GameObject ball;
    public GameObject ArmC;
    Vector3 ballTransf;
    private void Start()
    {
       // Vector3 ballTransf = ball.transform.position;
    }

    public void Reset()
    {
        
        ball.transform.parent = ArmC.transform;
        ball.transform.localPosition = new Vector3(-0.054f, -1.583f, -3.886998f);
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ArmC.transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }
}
