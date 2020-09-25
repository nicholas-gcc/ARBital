using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadConcepts : MonoBehaviour
{
    public void LoadEA()
    {
        SceneManager.LoadScene("ElecAddExp");
    }

    public void LoadES()
    {
        SceneManager.LoadScene("ElecSubExp");
    }

    public void LoadSN1()
    {
        SceneManager.LoadScene("SN1Exp");
    }

    public void LoadSN2()
    {
        SceneManager.LoadScene("SN2Exp");
    }

    public void LoadNA()
    {
        SceneManager.LoadScene("NuclAddExp");
    }

    public void LoadChirality()
    {
        SceneManager.LoadScene("ChiralityExp");
    }
}
