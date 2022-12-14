using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPressNotice : MonoBehaviour
{
    [SerializeField] QuestionResults results;
    public void NoticeClick()
    {

        string ClickedButtonName = gameObject.name;

        switch (ClickedButtonName)
        {
            case "CorrectAnswer":


                Debug.Log("NR of Correct Answers");
                results.correctAnswers += 1;
                Debug.Log(results.correctAnswers);

                Debug.Log("NR of current question");
                results.thisScenenNR += 1;
                Debug.Log(results.thisScenenNR);

                break;

            case "WrongAnswer":



                Debug.Log("NR of Wrong answers");
                results.wrongAnswers += 1;
                Debug.Log(results.wrongAnswers);

                Debug.Log("NR of current question");
                results.thisScenenNR += 1;
                Debug.Log(results.thisScenenNR);

                break;

        }


    }
}
