using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartAR()
    {
        SceneManager.LoadScene("MoleculAR");
    }

    public void InstructionsInterface()
    {
        SceneManager.LoadScene("InstructionsPage");
    }

    public void ConceptsPage()
    {
        SceneManager.LoadScene("ConceptsPage");
    }

    public void QuitApp()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
