using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public static float scale;
    public Slider slider;
    public GameObject gameobject;

    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.Find("SizeSlider").GetComponent<Slider>();
        slider.value = PlayerPrefs.GetFloat("SizeSlider");
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("SizeSlider", slider.value);
        SliderScript.scale = slider.value;
        gameobject.transform.localScale = new Vector3(scale, scale, scale);
    }
}
