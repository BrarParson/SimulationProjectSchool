using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcclerationScript : MonoBehaviour
{

    Text text;
    public Slider accelerationSlider;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent <Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ("Acceleration: " + accelerationSlider.value);
    }
}
