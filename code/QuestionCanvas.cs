using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using OpenTDB;

public class QuestionCanvas : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Text textQuestion = null;

    [SerializeField]
    AnswerButton a1 = null;

    [SerializeField]
    AnswerButton a2 = null;

    [SerializeField]
    AnswerButton a3 = null;

    [SerializeField]
    AnswerButton a4 = null;

    public static List<int> toShuffle = new List<int>() { 1, 2, 3, 4 };

    public static List<int> Shuffle(List<int> list)
    {
        // Creating a new list so I can maintain the unshuffled list

        List<int> newList = list;
        for (int n = 0; n < newList.Count; n++)
        {
            int temp = newList[n];
            int randomIndex = (Random.Range(n, newList.Count));
            newList[n] = newList[randomIndex];
            newList[randomIndex] = temp; 
            
        }
        return newList;
    }
    public void SetQuestion(Question q)
    {
        if (textQuestion)
            textQuestion.text = q.question;
        List<int> order = Shuffle(toShuffle);
        for(int n = 0; n < order.Count; n++)
        {
            switch (order[n])
            {
                case 1:
                    SetAnswer(n, a1, q);
                    break;
                case 2:
                    SetAnswer(n, a2, q);
                    break;
                case 3:
                    SetAnswer(n, a3, q);
                    break;
                case 4:
                    SetAnswer(n, a4, q);
                    break;
            }
        }

    }

    public void SetAnswer(int n, AnswerButton button, Question q)
    {
        if (n == 0)
        {
            button.SetText(q.correct_answer);
            button.isCorrect = true;
        }
        else
        {
            button.SetText(q.incorrect_answers[n - 1]);
            button.isCorrect = false;
        }
    }
}
