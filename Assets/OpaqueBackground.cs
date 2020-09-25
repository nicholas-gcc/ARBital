using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpaqueBackground : MonoBehaviour
{
    public float aValue = 1;
    private CanvasGroup trans;

    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<CanvasGroup>();
        trans.alpha = aValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
