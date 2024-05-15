using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Methode, um auf eine andere Szene zu verweisen
    public void LoadScene()
    {
        SceneManager.LoadScene("AR-Camera");
    }

    // Methode, um die App zu schlieﬂen
    public void QuitApplication()
    {
        Application.Quit();
    }
}
