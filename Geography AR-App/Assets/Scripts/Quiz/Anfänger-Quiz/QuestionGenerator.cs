using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;

    // Eine Liste, um die Fragen zu speichern
    private List<Question> questions = new List<Question>();

    // Eine Klasse, um die Frage, die Antwortmöglichkeiten und die richtige Antwort zu speichern
    private class Question
    {
        public string question;
        public string[] options;
        public string answer;

        public Question(string question, string[] options, string answer)
        {
            this.question = question;
            this.options = options;
            this.answer = answer;
        }
    }

    // Index, um die aktuelle Frage in der Liste zu verfolgen
    private int currentQuestionIndex = 0;

    public GameObject visual01;
    public GameObject endQuizPopup; // Das Popup-GameObject

    void Start()
    {
        // Füge die Fragen zur Liste hinzu
        questions.Add(new Question("Was ist die Hauptstadt von Hessen?", new string[] { "A. Frankfurt", "B. Darmstadt", "C. Wiesbaden", "D. Kassel" }, "C"));
        questions.Add(new Question("Welches Bundesland hat die Inseln Rügen und Usedom?", new string[] { "A. Schleswig-Holstein", "B. Hamburg", "C. Mecklenburg-Vorpommern", "D. Niedersachsen" }, "C"));
        questions.Add(new Question("Welches ist das größte Bundesland Deutschlands?", new string[] { "A. Nordrhein-Westfalen", "B. Baden-Württemberg", "C. Niedersachsen", "D. Bayern" }, "D"));
        questions.Add(new Question("Wie viele Bundesländer hat Deutschland insgesamt?", new string[] { "A. 12", "B. 16", "C. 20", "D. 17" }, "B"));
        questions.Add(new Question("In welchem Bundesland steht das Brandenburger Tor?", new string[] { "A. Brandenburg", "B. Berlin", "C. Niedersachsen", "D. Nordrhein-Westfalen" }, "B"));
        questions.Add(new Question("Welches Bundesland wird hier dargestellt?", new string[] { "A. Sachsen", "B. Bremen", "C. Schleswig-Holstein", "D. Thüringen" }, "D"));
        questions.Add(new Question("Welches Bundesland ist bekannt für den Kölner Dom?", new string[] { "A. Hamburg", "B. Nordrhein-Westfalen", "C. Schleswig-Holstein", "D. Rheinland-Pfalz" }, "B"));
        questions.Add(new Question("In welchem Bundesland liegt die Stadt Dresden?", new string[] { "A. Thüringen", "B. Sachsen-Anhalt", "C. Sachsen", "D. Brandenburg" }, "C"));
        questions.Add(new Question("Welches Bundesland hat Berlin als Hauptstadt?", new string[] { "A. Bayern", "B. Berlin", "C. Brandenburg", "D. Sachsen" }, "B"));

        // Mische die Fragen, um eine zufällige Reihenfolge zu erhalten
        ShuffleQuestions();
    }

    void Update()
    {
        // Überprüfe, ob alle Fragen beantwortet wurden
        if (currentQuestionIndex < questions.Count)
        {
            // Zeige die nächste Frage an, wenn keine Frage angezeigt wird
            if (!displayingQuestion)
            {
                DisplayNextQuestion();
            }
        }
        else
        {
            // Wenn alle Fragen beantwortet wurden, beende das Quiz
            EndQuiz();
        }
    }

    // Methode, um die Fragen zu mischen
    void ShuffleQuestions()
    {
        for (int i = 0; i < questions.Count; i++)
        {
            Question temp = questions[i];
            int randomIndex = Random.Range(i, questions.Count);
            questions[i] = questions[randomIndex];
            questions[randomIndex] = temp;
        }
    }

    // Methode, um die nächste Frage anzuzeigen
    void DisplayNextQuestion()
    {
        displayingQuestion = true;
        Question currentQuestion = questions[currentQuestionIndex];
        QuestionDisplay.newQuestion = currentQuestion.question;
        QuestionDisplay.newA = currentQuestion.options[0];
        QuestionDisplay.newB = currentQuestion.options[1];
        QuestionDisplay.newC = currentQuestion.options[2];
        QuestionDisplay.newD = currentQuestion.options[3];
        actualAnswer = currentQuestion.answer;
        currentQuestionIndex++;

        // Prüfe, ob es sich um die Frage "Welches Bundesland wird hier dargestellt?" handelt
        if (currentQuestion.question == "Welches Bundesland wird hier dargestellt?")
        {
            visual01.SetActive(true);
        }
        else
        {
            visual01.SetActive(false);
        }

        QuestionDisplay.pleaseUpdate = false;
    }


    // Methode, um das Quiz zu beenden
    void EndQuiz()
    {
        endQuizPopup.SetActive(true);
    }

    public void RestartQuiz()
    {
        // Setze statische Variablen zurück
        actualAnswer = null;
        displayingQuestion = false;
        currentQuestionIndex = 0;

    }
}