using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallDistance : MonoBehaviour
{

    Rigidbody rb;
    public Text distanceDisplay;
    public GameObject catapult;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity == Vector3.zero)
        {
            distanceDisplay.enabled = true;
            float distance = Vector3.Distance(catapult.transform.position, transform.position);
            int fDistance = Mathf.RoundToInt(distance);
            distanceDisplay.text = ("Distance: " + fDistance + "m");
        }

        if (transform.parent != null)
        {
            distanceDisplay.enabled = false;
        }
    }
}
