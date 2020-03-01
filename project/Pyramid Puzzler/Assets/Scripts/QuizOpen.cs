using System;
using System.Collections.Generic;
using UnityEngine;

using OpenTDB;

public class QuizOpen : MonoBehaviour
{
    private static QuizOpen instance = null;

    [SerializeField]

    private QuestionRequest api = null;

    [SerializeField]

    private QuestionCanvas canvas = null;

    private List<Question> question;

    public static bool quizOpen = false;

    public GameObject quizUI;

    // Update is called once per frame

    void Update()
    {
        // Replace  with stepping on tiles later on
        if (Input.GetKeyDown(KeyCode.Q) && !quizOpen)
        {
            if (api) // Checks if the api is present.
            {
                api.MakeRequest(
                    new Action<Response>((Response response) =>
                    { 
                        question = response.results;
                        Quiz();
                    })
                    );
            }
            else
            {

            }
            instance = this;
        }
    }

    public static QuizOpen GetInstance()
    {
        return instance;
    }

    // Again, just for testing
    // This will actually be done in a quiz class later on
    public void Resume()
    {
        quizUI.SetActive(false);
        Time.timeScale = 1f;
        quizOpen = false;
    }

    public void Quiz()
    {
        quizUI.SetActive(true);
        Time.timeScale = 0f;
        quizOpen = true;
        Question q = question[0];
        if (canvas)
            canvas.SetQuestion(q);
    }

    public void Answer(AnswerButton selection)
    {
        if (selection.isCorrect)
            Correct();
        else
            Incorrect();
    }

    public void Correct()
    {
        Debug.Log("Correct!");
        Resume();

    }

    // When lives are implemented, it will also subtract a life
    public void Incorrect()
    {
        Debug.Log("Incorrect");
    }
}
