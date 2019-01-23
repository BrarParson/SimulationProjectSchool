using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Button2 : MonoBehaviour
{
    public Rigidbody ab;
    public bool moving = false;
    private float t = 0.0f;
    
    
    //public Button button;
    // Use this for initialization
    public void Start()
    {
        ab = GetComponent<Rigidbody>();
        Debug.Log("start");
    }

    // Update is called once per frame
   public void POP()
    {
            Debug.Log("part 2");
            ab.velocity = new Vector3(0, 30, 0);
            moving = true;
        
        if (moving)
        
            // when the cube has moved over 1 second report it's position
            t = t + Time.deltaTime;
            if (t > 1.0f)
            {
                Debug.Log(gameObject.transform.position.y + " : " + t);
                t = 0.0f;
            moving = false;
            }
        }
    }


