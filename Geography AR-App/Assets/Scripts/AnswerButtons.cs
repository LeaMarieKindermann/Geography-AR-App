using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerButton; // Der Button, auf den du zugreifen möchtest
    public Sprite blueImage; // Bild für den normalen Zustand (blau)
    public Sprite greenImage; // Bild für den korrekten Zustand (grün)
    public Sprite redImage; // Bild für den falschen Zustand (rot)

    // Diese Methode wird aufgerufen, wenn der Button gedrückt wird
    public void AnswerButtonPressed()
    {
        // Überprüfe, ob die Antwort korrekt ist
        if (QuestionGenerator.actualAnswer == "A")
        {
            // Setze das Bild auf grün (korrekt)
            answerButton.GetComponent<Image>().sprite = greenImage;
        }
    }
}

