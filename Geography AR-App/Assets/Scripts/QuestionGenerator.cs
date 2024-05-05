using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{

    public static string actualAnswer;
    public static bool displayingQuestion = false; 

    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            QuestionDisplay.newQuestion = "Was ist die Hauptstadt von Hessen?";
            QuestionDisplay.newA = "A. Frankfurt";
            QuestionDisplay.newB = "B. Darmstadt";
            QuestionDisplay.newC = "C. Wiesbaden";
            QuestionDisplay.newD = "D. Kassel";
            actualAnswer = "A";
        }
    }
}
