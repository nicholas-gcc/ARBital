using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class SliderScale : MonoBehaviour
{
    public float scale;
    public Slider slider;
    public Vector3 size;
    public float x;
    public float y;
    public float z;

    void Start()
    {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        size = transform.localScale;
        x = size.x;
        y = size.y;
        z = size.z;
    }

    // Update is called once per frame
    public void Update()
    {
        scale = slider.value;
        transform.localScale = new Vector3(scale * x, scale * y, scale * z);
    }
}
