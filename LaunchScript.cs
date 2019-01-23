using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject arm;
    public Rigidbody origin;
    public float acceleration;
    float speed = 1;
    public float maxAngle;
    bool running = false;
    public Slider slider;

    private void Start()
    {
        acceleration = slider.value;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            running = true;
        }

        if (running)
        {
            Launch();
        }
    }

    void Launch()
    {
        acceleration = slider.value;
        transform.Rotate(Vector3.right * Time.deltaTime * speed);

        if (transform.eulerAngles.x <= maxAngle)
        {
            speed += acceleration;
        } else
        {
            ball.transform.parent = null;
            ball.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            ball.GetComponent<Rigidbody>().velocity = new Vector3(0f, CalcVelocity().y, CalcVelocity().z);
            //StartCoroutine(delay());
            running = false;
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(1f);
    }

    Vector3 CalcVelocity()
    {
        float R = 5;
        float velocity = Mathf.Sqrt(R * acceleration);
        float Ax = velocity * Mathf.Cos(transform.localEulerAngles.x);
        float Ay = velocity * Mathf.Sin(transform.localEulerAngles.x);
        if (Ax < 0)
        {
            Ax = Ax * -1;
        }

        if (Ay < 0)
        {
            Ay = Ay * -1;
        }
        return new Vector3(0, Ay, Ax);
    }
}
