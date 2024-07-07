using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionGeneratorFortgeschritten : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;

    // Eine Liste, um die Fragen zu speichern
    private List<Question> questions = new List<Question>();

    public GameObject Cbutton; 

    public GameObject Dbutton; 

    public GameObject Abutton; 

    public GameObject Bbutton; 

    public GameObject Menubutton; 

    // Eine Klasse, um die Frage, die Antwortm�glichkeiten und die richtige Antwort zu speichern
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

        // F�ge die Fragen zur Liste hinzu
        questions.Add(new Question("Welches Bundesland ist bekannt für seine Weinanbaugebiete entlang des Rheins?", new string[] { "A. Schleswig-Holstein", "B. Bayern", "C. Rheinland-Pfalz", "D. Hessen" }, "C"));
        questions.Add(new Question("Welches Bundesland grenzt an Frankreich und der Schweiz?", new string[] { "A. Sachsen", "B. Baden-Württemberg", "C. Berlin", "D. Niedersachsen" }, "B"));
        questions.Add(new Question("Welches Bundesland hat die meisten UNESCO-Weltkulturerbestätten in Deutschland?", new string[] { "A. Bayern", "B. Sachsen", "C. Rheinland-Pfalz", "D. Nordrhein-Westfalen" }, "A"));
        questions.Add(new Question("Welches Bundesland wird auch als das Land der 1000 Seen bezeichnet?", new string[] { "A. Schleswig-Holstein", "B. Brandenburg", "C. Sachsen-Anhalt", "D. Mecklenburg-Vorpommern" }, "D"));
        questions.Add(new Question("In welchem Bundesland liegt die höchste Erhebung Deutschlands, die Zugspitze?", new string[] { "A. Baden-Württemberg", "B. Bayern", "C. Thüringen", "D. Sachsen" }, "B"));
        questions.Add(new Question("Welches Bundesland hat diese Flagge?", new string[] { "A. Bremen", "B. Hamburg", "C. Nordrhein-Westfalen", "D. Saarland" }, "A"));
        questions.Add(new Question("Welches Bundesland hat den kleinsten Anteil an der Gesamtfläche Deutschlands?", new string[] { "A. Saarland", "B. Bremen", "C. Berlin", "D. Hamburg" }, "B"));
        questions.Add(new Question("Welcher Fluss fließt durch Fulda und Kassel?", new string[] { "A. Rhein", "B. Donau", "C. Fulda", "D. Main" }, "C"));
        questions.Add(new Question("In welchem Land entspringt die Donau?", new string[] { "A. Deutschland", "B. Österreich", "C. Schweiz", "D. Tschechien" }, "A"));
        questions.Add(new Question("Welches Bundesland ist für das alljährliche Oktoberfest bekannt?", new string[] { "A. Hamburg", "B. Sachsen-Anhalt", "C. Bayern", "D. Bremen" }, "C"));
        questions.Add(new Question("Welches Bundesland liegt nicht im Westen Deutschlands?", new string[] { "A. Brandenburg", "B. Rheinland-Pfalz", "C. Saarland", "D. Nordrhein-Westfalen" }, "A"));
        questions.Add(new Question("Welches Bundesland ist bekannt für Schiller und Goethe?", new string[] { "A. Thüringen", "B. Niedersachsen", "C. Schlieswig-Holstein", "D. Hessen" }, "A"));

        // Mische die Fragen, um eine zuf�llige Reihenfolge zu erhalten
        ShuffleQuestions();
        DisplayNextQuestion();
    }

    void Update()
    {
        // �berpr�fe, ob alle Fragen beantwortet wurden
        if (currentQuestionIndex < 10)
        {
            // Zeige die n�chste Frage an, wenn keine Frage angezeigt wird
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

    // Methode, um die n�chste Frage anzuzeigen
    void DisplayNextQuestion()
    {
        displayingQuestion = true;
        Question currentQuestion = questions[currentQuestionIndex];
        QuestionDisplayFortgeschritten.newQuestion = currentQuestion.question;
        QuestionDisplayFortgeschritten.newA = currentQuestion.options[0];
        QuestionDisplayFortgeschritten.newB = currentQuestion.options[1];
        QuestionDisplayFortgeschritten.newC = currentQuestion.options[2];
        QuestionDisplayFortgeschritten.newD = currentQuestion.options[3];
        actualAnswer = currentQuestion.answer;

        // Pr�fe, ob es sich um die Frage "Welches Bundesland wird hier dargestellt?" handelt
        if (currentQuestion.question == "Welches Bundesland hat diese Flagge?")
        {
            visual01.SetActive(true);
        }
        else
        {
            visual01.SetActive(false);
        }

        QuestionDisplayFortgeschritten.pleaseUpdate = false;
        currentQuestionIndex++;
    }


    // Methode, um das Quiz zu beenden
    void EndQuiz()
    {
        endQuizPopup.SetActive(true);
        Menubutton.GetComponent<Button>().interactable = false;
        Cbutton.GetComponent<Button>().interactable = false;
        Dbutton.GetComponent<Button>().interactable = false;
        Abutton.GetComponent<Button>().interactable = false;
        Bbutton.GetComponent<Button>().interactable = false;
    }

    public void RestartQuiz()
    {
        // Setze statische Variablen zur�ck
        actualAnswer = null;
        displayingQuestion = false;
    }
}