using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustSize : MonoBehaviour
{
    public static float currScale;

    void Start()
    {
        currScale = SliderScript.scale;
    }

    public void updateSize()
    {
        transform.localScale = new Vector3(currScale, currScale, currScale);
    }
}
