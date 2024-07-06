using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PopUpMenu : MonoBehaviour
{

    public GameObject popup;

    public GameObject Cbutton; 
    public GameObject Dbutton; 
    public GameObject Abutton; 
    public GameObject Bbutton; 


    public void PauseButton()
    {
        popup.SetActive(true);
        Cbutton.GetComponent<Button>().interactable = false;
        Dbutton.GetComponent<Button>().interactable = false;
        Abutton.GetComponent<Button>().interactable = false;
        Bbutton.GetComponent<Button>().interactable = false;
    }

    public void Fortsetzen()
    {
        popup.SetActive(false);
        Cbutton.GetComponent<Button>().interactable = true;
        Dbutton.GetComponent<Button>().interactable = true;
        Abutton.GetComponent<Button>().interactable = true;
        Bbutton.GetComponent<Button>().interactable = true;
    }

    public void Zurück()
    {
        SceneManager.LoadScene("Quiz-Auswahl");
    }

    public void Beenden()
    {
        FindObjectOfType<QuestionGenerator>().RestartQuiz();
        SceneManager.LoadScene("Quiz-Auswahl");
    }

    public void BeendenFortgeschritten()
    {
        FindObjectOfType<QuestionGeneratorFortgeschritten>().RestartQuiz();
        SceneManager.LoadScene("Quiz-Auswahl");
    }

    public void RestartAnfänger()
    {
        // Lade die Szene neu
        FindObjectOfType<QuestionGenerator>().RestartQuiz();
        SceneManager.LoadScene("Anfänger-Quiz");
    }

    public void RestartFortgeschritten()
    {
        // Lade die Szene neu
        FindObjectOfType<QuestionGeneratorFortgeschritten>().RestartQuiz();
        Debug.Log("GEFUNDEN");
        SceneManager.LoadScene("Fortgeschrittenen-Quiz");
    }

    public void BeendenE()
    {
        FindObjectOfType<QuestionGeneratorE>().RestartQuiz();
        SceneManager.LoadScene("Quiz-Auswahl");
    }

    public void RestartE()
    {
        // Lade die Szene neu
        FindObjectOfType<QuestionGeneratorE>().RestartQuiz();
        Debug.Log("GEFUNDEN");
        SceneManager.LoadScene("Experten-Quiz");
    }
}
