using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionDisplay : MonoBehaviour
{
    // Text-Objects for questions and answers
    public TextMeshProUGUI screenQuestion;
    public TextMeshProUGUI answerA;
    public TextMeshProUGUI answerB;
    public TextMeshProUGUI answerC;
    public TextMeshProUGUI answerD;
    
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;

    void Start()
    {
        StartCoroutine(PushTextOnScreen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.text = newQuestion;
        answerA.text = newA;
        answerB.text = newB;
        answerC.text = newC;
        answerD.text = newD;
    }
}
