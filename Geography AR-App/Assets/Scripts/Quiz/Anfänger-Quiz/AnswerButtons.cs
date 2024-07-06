using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerButtonA;
    public GameObject answerButtonB;
    public GameObject answerButtonC;
    public GameObject answerButtonD;

    public Sprite blueImage; // Bild f�r den normalen Zustand (blau)
    public Sprite greenImage; // Bild f�r den korrekten Zustand (gr�n)
    public Sprite redImage; // Bild f�r den falschen Zustand (rot)

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

    // Parameter f�r Quiz-ID
    public int quizID;

    // Sterne UI
    public Image star1;
    public Image star2;
    public Image star3;

    public Sprite filledStar; // Gef�llter Stern
    public Sprite emptyStar; // Leerer Stern

    void Start()
    {
        // Verwende den Parameter f�r den PlayerPrefs-Schl�ssel
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz" + quizID);
        bestDisplay.text = "Best: " + bestScore;
        UpdateStarDisplay(bestScore);
    }

    void Update()
    {
        currentScore.text = "Score: " + scoreValue;
    }

    // Diese Methode wird aufgerufen, wenn der Button gedr�ckt wird
    public void AnswerA()
    {
        // �berpr�fe, ob die Antwort korrekt ist
        if (QuestionGenerator.actualAnswer == "A")
        {
            // Setze das Bild auf gr�n (korrekt)
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
        // �berpr�fe, ob die Antwort korrekt ist
        if (QuestionGenerator.actualAnswer == "B")
        {
            // Setze das Bild auf gr�n (korrekt)
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
        // �berpr�fe, ob die Antwort korrekt ist
        if (QuestionGenerator.actualAnswer == "C")
        {
            // Setze das Bild auf gr�n (korrekt)
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
        // �berpr�fe, ob die Antwort korrekt ist
        if (QuestionGenerator.actualAnswer == "D")
        {
            // Setze das Bild auf gr�n (korrekt)
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
            UpdateStarDisplay(bestScore);
        }

        yield return new WaitForSeconds(2);
        visual01.SetActive(false);
        ResetButtonImages();

        EnableButtons();

        QuestionGenerator.displayingQuestion = false;
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

    void UpdateStarDisplay(int score)
    {
        // Setze alle Sterne auf leer
        star1.sprite = emptyStar;
        star2.sprite = emptyStar;
        star3.sprite = emptyStar;

        // Vergib Sterne basierend auf dem Score
        if (score >= 10)
        {
            star1.sprite = filledStar;
        }
        if (score >= 25)
        {
            star2.sprite = filledStar;
        }
        if (score >= 45)
        {
            star3.sprite = filledStar;
        }
    }
}
