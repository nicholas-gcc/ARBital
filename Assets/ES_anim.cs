using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Events;


public class ES_anim : MonoBehaviour
{
    public GameObject vbBtnObj;
    public GameObject obj;
    public Animation anim;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("ESButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        anim = obj.GetComponent<Animation>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anim["Scene"].speed = 0;
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        anim["Scene"].speed = 1;
        Debug.Log("Button released");
    }
}
