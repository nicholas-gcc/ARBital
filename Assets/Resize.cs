using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    /*
     * This class is temporary and only used to test resizing functionality for AR models
     * Resizing will be abstracted to an Options interface in future prototypes
     * 
     */
    public float scalingspeed = 0.01f;
    public bool ScaleUp = false;
    public bool ScaleDown = false;

    // Update is called once per frame
    void Update()
    {
        if (ScaleUp == true)
            ScaleUpButton();
        if (ScaleDown == true)
            ScaleDownButton();
    }

    public void ScaleUpButton()
    {
        GameObject.FindWithTag("MethaneModel").transform.localScale += new Vector3(scalingspeed, scalingspeed, scalingspeed);
    }
    public void ScaleDownButton()
    {
        GameObject.FindWithTag("MethaneModel").transform.localScale += new Vector3(-scalingspeed, -scalingspeed, -scalingspeed);
    }

    public void Up()
    {
        ScaleUp = true;
        ScaleDown = false;
    }
    public void Down()
    {
        ScaleUp = false;
        ScaleDown = true;
    }
    public void Stop()
    {
        ScaleUp = false;
        ScaleDown = false;
    }
}
