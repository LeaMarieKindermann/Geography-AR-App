using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject menu; 

    public void openMenu()
    {
        menu.SetActive(true);
    }

    public void closeMenu()
    {
        menu.SetActive(false);
    }

    public void Quiz()
    {
        SceneManager.LoadScene("Quiz-Auswahl");
    }

    public void Infoseiten()
    {
        SceneManager.LoadScene("Informationsseiten");
    }
}
