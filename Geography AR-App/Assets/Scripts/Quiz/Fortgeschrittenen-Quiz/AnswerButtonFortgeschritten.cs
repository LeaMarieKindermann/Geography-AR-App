using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnswerButtonFortgeschritten : MonoBehaviour
{
    public GameObject answerButtonA;
    public GameObject answerButtonB;
    public GameObject answerButtonC;
    public GameObject answerButtonD;

    public Sprite blueImage; // Bild für den normalen Zustand (blau)
    public Sprite greenImage; // Bild für den korrekten Zustand (grün)
    public Sprite redImage; // Bild für den falschen Zustand (rot)

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public AudioSource correctFX;
    public AudioSource wrongFX;

    public TextMeshProUGUI currentScore;
    public int scoreValue;
    private int bestScore;
    public TextMeshProUGUI bestDisplay;

    public GameObject visual01;

    // Parameter für Quiz-ID
    public int quizID;

    void Start()
    {
        // Verwende den Parameter für den PlayerPrefs-Schlüssel
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz" + quizID);
        bestDisplay.text = "Best: " + bestScore;
    }

    void Update()
    {
        currentScore.text = "Score: " + scoreValue;
    }

    // Diese Methode wird aufgerufen, wenn der Button gedrückt wird
    public void AnswerA()
    {
        // Überprüfe, ob die Antwort korrekt ist
        if (QuestionGeneratorFortgeschritten.actualAnswer == "A")
        {
            // Setze das Bild auf grün (korrekt)
            answerButtonA.GetComponent<Image>().sprite = greenImage;
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerButtonA.GetComponent<Image>().sprite = redImage;
            wrongFX.Play();
        }
        DisableButtons();
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        // Überprüfe, ob die Antwort korrekt ist
        if (QuestionGeneratorFortgeschritten.actualAnswer == "B")
        {
            // Setze das Bild auf grün (korrekt)
            answerButtonB.GetComponent<Image>().sprite = greenImage;
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerButtonB.GetComponent<Image>().sprite = redImage;
            wrongFX.Play();
        }
        DisableButtons();
        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        // Überprüfe, ob die Antwort korrekt ist
        if (QuestionGeneratorFortgeschritten.actualAnswer == "C")
        {
            // Setze das Bild auf grün (korrekt)
            answerButtonC.GetComponent<Image>().sprite = greenImage;
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerButtonC.GetComponent<Image>().sprite = redImage;
            wrongFX.Play();
        }
        DisableButtons();
        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        // Überprüfe, ob die Antwort korrekt ist
        if (QuestionGeneratorFortgeschritten.actualAnswer == "D")
        {
            // Setze das Bild auf grün (korrekt)
            answerButtonD.GetComponent<Image>().sprite = greenImage;
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerButtonD.GetComponent<Image>().sprite = redImage;
            wrongFX.Play();
        }
        DisableButtons();
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz" + quizID, scoreValue);
            bestScore = scoreValue;
            bestDisplay.text = "Best: " + scoreValue;
        }

        yield return new WaitForSeconds(2);
        visual01.SetActive(false);
        ResetButtonImages();

        EnableButtons();

        QuestionGeneratorFortgeschritten.displayingQuestion = false;
    }

    void DisableButtons()
    {
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
    }

    void EnableButtons()
    {
        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;
    }

    void ResetButtonImages()
    {
        answerButtonA.GetComponent<Image>().sprite = blueImage;
        answerButtonB.GetComponent<Image>().sprite = blueImage;
        answerButtonC.GetComponent<Image>().sprite = blueImage;
        answerButtonD.GetComponent<Image>().sprite = blueImage;
    }
}
