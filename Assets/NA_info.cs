using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
using UnityEngine.Events;

public class NA_info : MonoBehaviour
{
    public GameObject vbBtnObj;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("NAInfo");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        SceneManager.LoadScene("NuclAddExp");
        Debug.Log("Button released");
    }
}