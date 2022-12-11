using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;


//public class QuestionNumber : MonoBehaviour
//{
//    public int questionIndex;

//    public void GetQuestionNumber()
//    {
//        questionIndex = QuestionExpert.instance.QuestionNR;
//    }
//}
////public class ButtonPressNotice : MonoBehaviour
////{    // Start is called before the first frame update
////    public Button YourButton;
////    public Button YourButton1;
////    public Button YourButton2;
////    public Button YourButton3;
////    public bool ispressed = false;

////    [SerializeField]
////    int questionsNR;
////    QuestionExpert QuestionSystem;
    
////    void Start()
////    {
      
////        Button btn = YourButton.GetComponent<Button>();
////        Button btn1 = YourButton1.GetComponent<Button>();
////        Button btn2 = YourButton2.GetComponent<Button>();
////        Button btn3 = YourButton3.GetComponent<Button>();
////        btn.onClick.AddListener(TaskOnClick);
////        btn1.onClick.AddListener(TaskOnClick);
////        btn2.onClick.AddListener(TaskOnClick);
////        btn3.onClick.AddListener(TaskOnClick);

////        if (ispressed == true)
////        {
////            TaskOnClick();
////        }
        
////    }
////    public void TaskOnClick()
////    {
////        Debug.Log("You have clicked the button!");
////        QuestionSystem = FindObjectOfType<QuestionExpert>();
////        questionsNR = QuestionSystem.CurrentQuestions;
////        questionsNR += 1;
////        QuestionSystem.SetQuestionNR(questionsNR);
////        ispressed = true;
        
////    }

////}
