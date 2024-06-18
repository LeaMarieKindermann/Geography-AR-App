using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGeneratorExperten : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;

    // Eine Liste, um die Fragen zu speichern
    private List<Question> questions = new List<Question>();

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
        questions.Add(new Question("Welches Bundesland beherbergt den Schwarzwald, eines der gr��ten Mittelgebirge Deutschlands?", new string[] { "A. Bayern", "B. Baden-W�rttemberg", "C. Niedersachsen", "D. Sachsen" }, "B"));
        questions.Add(new Question("Welches Bundesland hat die meisten Einwohner?", new string[] { "A. Bayern", "B. Nordrhein-Westfalen", "C. Baden-W�rttemberg", "D. Hessen" }, "B"));
        questions.Add(new Question("Welches Bundesland grenzt nicht an das Ausland?", new string[] { "A. Bayern", "B. Saarland", "C. Brandenburg", "D. Niedersachsen" }, "D"));
        questions.Add(new Question("Welches Bundesland ist f�r seine vielf�ltige Automobilindustrie bekannt, unter anderem mit Standorten wie Wolfsburg und Stuttgart?", new string[] { "A. Bayern", "B. Niedersachsen", "C. Baden-W�rttemberg", "D. Nordrhein-Westfalen" }, "C"));
        questions.Add(new Question("Welches von den unten erw�hnten Staaten ist ein Sadtstaat?", new string[] { "A. Bremen", "B. Sachsen", "C. Niedersachsen", "D. Nordrhein-Westfalen" }, "A"));
        questions.Add(new Question("In welchem Bundesland liegt der Harz, ein Mittelgebirge bekannt f�r seine reiche Bergbauhistorie und seine beeindruckende Natur?", new string[] { "A. Niedersachsen", "B. Nordrhein-Westfalen", "C. Hessen", "D. Sachsen-Anhalt" }, "D"));
        questions.Add(new Question("Welcher Fluss flie�t durch die St�dte Dresden, Magdeburg und Hamburg?", new string[] { "A. Rhein", "B. Donau", "C. Elbe", "D. Main" }, "C"));
        questions.Add(new Question("Welcher Fluss ist der l�ngste innerhalb Deutschlands?", new string[] { "A. Rhein", "B. Donau", "C. Elbe", "D. Main" }, "B"));
        questions.Add(new Question("In welchem Bundesland liegt die V�lklinger H�tte, die erste industrielle Kulturst�tte, die von der UNESCO zum Weltkulturerbe erkl�rt wurde?", new string[] { "A. Saarland", "B. Nordrhein-Westfalen", "C. Sachsen-Anhalt", "D. Rheinland-Pfalz" }, "A"));
        // Mische die Fragen, um eine zuf�llige Reihenfolge zu erhalten
        ShuffleQuestions();
    }

    void Update()
    {
        // �berpr�fe, ob alle Fragen beantwortet wurden
        if (currentQuestionIndex < questions.Count)
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
        QuestionDisplayExperten.newQuestion = currentQuestion.question;
        QuestionDisplayExperten.newA = currentQuestion.options[0];
        QuestionDisplayExperten.newB = currentQuestion.options[1];
        QuestionDisplayExperten.newC = currentQuestion.options[2];
        QuestionDisplayExperten.newD = currentQuestion.options[3];
        actualAnswer = currentQuestion.answer;
        currentQuestionIndex++;

        // Pr�fe, ob es sich um die Frage "Welches Bundesland wird hier dargestellt?" handelt
        /* if (currentQuestion.question == "Welches Bundesland wird hier dargestellt?")
        {
            visual01.SetActive(true);
        }
        else
        {
            visual01.SetActive(false);
        } */

        QuestionDisplayExperten.pleaseUpdate = false;
    }


    // Methode, um das Quiz zu beenden
    void EndQuiz()
    {
        endQuizPopup.SetActive(true);
    }

    public void RestartQuiz()
    {
        // Setze statische Variablen zur�ck
        actualAnswer = null;
        displayingQuestion = false;
        currentQuestionIndex = 0;

    }
}
