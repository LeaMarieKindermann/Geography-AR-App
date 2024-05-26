using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizSelection : MonoBehaviour
{
    public void AnfaengerQuiz()
    {
        SceneManager.LoadScene("Anfänger-Quiz");
    }

    public void FortgeschrittenenQuiz()
    {
        SceneManager.LoadScene("Fortgeschrittenen-Quiz");
    }

    public void ExpertenQuiz()
    {
        SceneManager.LoadScene("Experten-Quiz");
    }

    public void Quit()
    {
        SceneManager.LoadScene("AR-Camera");
    }
}
