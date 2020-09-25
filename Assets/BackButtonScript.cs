using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour
{
   public void BackButton()
    {
        SceneManager.LoadScene("Start menu");
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("MoleculAR");
    }
}
