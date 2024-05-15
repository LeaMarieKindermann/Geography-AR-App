using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizSelection : MonoBehaviour
{
    public void AnfaengerQuiz()
    {
        SceneManager.LoadScene("Quiz");
    }

    public void FortgeschrittenenQuiz()
    {
        // SceneManager.LoadScene("AR-Camera");
    }

    public void ExpertenQuiz()
    {
        // SceneManager.LoadScene("AR-Camera");
    }
}
