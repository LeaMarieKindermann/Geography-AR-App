using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUpMenu : MonoBehaviour
{

    public GameObject popup;

    public void PauseButton()
    {
        popup.SetActive(true);
    }

    public void Fortsetzen()
    {
        popup.SetActive(false);
    }

    public void Beenden()
    {
        SceneManager.LoadScene("Quiz-Auswahl");
    }

    public void Cross()
    {
        popup.SetActive(false);
    }
}
