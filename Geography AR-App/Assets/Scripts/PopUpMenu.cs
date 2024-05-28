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
        FindObjectOfType<QuestionGenerator>().RestartQuiz();
        SceneManager.LoadScene("Quiz-Auswahl");
    }

    public void BeendenFortgeschritten()
    {
        FindObjectOfType<QuestionGeneratorFortgeschritten>().RestartQuiz();
        SceneManager.LoadScene("Quiz-Auswahl");
    }

    public void BeendenExperte()
    {
        FindObjectOfType<QuestionGeneratorExperten>().RestartQuiz();
        SceneManager.LoadScene("Quiz-Auswahl");
    }

    public void Cross()
    {
        popup.SetActive(false);
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
        SceneManager.LoadScene("Fortgeschrittenen-Quiz");
    }

    public void RestartExperte()
    {
        // Lade die Szene neu
        FindObjectOfType<QuestionGeneratorExperten>().RestartQuiz();
        SceneManager.LoadScene("Experten-Quiz");
    }
}
