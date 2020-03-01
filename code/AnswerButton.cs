using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    [SerializeField]
    private Text textAnswer = null;

    public bool isCorrect = false;

    public void SetText(string text)
    {
        if (textAnswer)
            textAnswer.text = text;
    }

    public void Select()
    {
        QuizOpen.GetInstance().Answer(this);
    }
}
