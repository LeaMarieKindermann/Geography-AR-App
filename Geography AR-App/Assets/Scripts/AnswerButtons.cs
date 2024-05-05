using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerButton; // Der Button, auf den du zugreifen m�chtest
    public Sprite blueImage; // Bild f�r den normalen Zustand (blau)
    public Sprite greenImage; // Bild f�r den korrekten Zustand (gr�n)
    public Sprite redImage; // Bild f�r den falschen Zustand (rot)

    // Diese Methode wird aufgerufen, wenn der Button gedr�ckt wird
    public void AnswerButtonPressed()
    {
        // �berpr�fe, ob die Antwort korrekt ist
        if (QuestionGenerator.actualAnswer == "A")
        {
            // Setze das Bild auf gr�n (korrekt)
            answerButton.GetComponent<Image>().sprite = greenImage;
        }
    }
}

