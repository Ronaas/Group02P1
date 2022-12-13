
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
[ExecuteInEditMode]

public class Buttons : MonoBehaviour
{
    public List<Button> buttons;
    public void SceneDelay()
    {
        Invoke("LoadScene", 1f);
    }
    //public bool isSelected = false;
    //public bool trueAnswer = false;
    //public GameObject AAnswer;
    [SerializeField]
    public QuestionResults results;

    public void NoticeClick()
    {
        string ClickedButtonName = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(ClickedButtonName + "was pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        switch (ClickedButtonName)
        {
            case "CorrectAnswer":
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                Debug.Log("NR of current question");
                results.currentscene += 1;
                Debug.Log(results.currentscene);

                Debug.Log("NR of current question");
                results.correctAnswers += 1;
                Debug.Log(results.CorrectAnswer);

                break;

            case "WrongAnswer":
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                Debug.Log("NR of current question");
                results.currentscene += 1;
                Debug.Log(results.currentscene);

                Debug.Log("NR of Wrong answers");
                results.wrongAnswers += 1;
                Debug.Log(results.wrongAnswers);

                break;
           
        }
            
                
        }

    }



// der er i denne jeg i sidste ende skal formå at skifte imellem scenerne samtidigt men at genere data i. 
//public bool IsNextScene = false;
//public bool buttonPressed;


//    {
//        case("AAnswer == questionResults.CorrectAnswer"):
//            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//                    questionResults.currentscene += 1;
//                questionResults.correctAnswers += 1;
//            break;

//}       

//public void SceneDelay()
//{
//    Invoke("LoadScene", 1f);
//}
//public void LoadScene()
//{
//    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//}
//isSelected = true;
//void getTestInfo()
//{
//    Debug.Log("NR of current question");
//    Debug.Log(questionResults.currentscene);
//    Debug.Log("NR of correct answers");
//    Debug.Log(questionResults.correctAnswers);
//    Debug.Log("NR of Wrong answers");
//    Debug.Log(questionResults.wrongAnswers);
//}
//string info = getTestInfo(); 

//switch (AAnswer)
//        {
//            case("AAnswer == questionResults.CorrectAnswer"):
//                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//                        questionResults.currentscene += 1;
//                        questionResults.correctAnswers += 1;
//                break;

//        }


//skal nok laves om til en case/switch i senere
//{
//    if (CorrectAnswer == trueAnswer)
//    {
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//        questionResults.currentscene += 1;
//        questionResults.correctAnswers += 1;
//        Debug.Log("NR of current question");
//        Debug.Log(questionResults.currentscene);
//        Debug.Log("NR of correct answers");
//        Debug.Log(questionResults.correctAnswers);
//    } 
//    if(CorrectAnswer!= trueAnswer)
//    {
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//        questionResults.currentscene += 1;
//        questionResults.wrongAnswers += 1;
//        Debug.Log("NR of current question");
//        Debug.Log(questionResults.currentscene);
//        Debug.Log("NR of Wrong answers");
//        Debug.Log(questionResults.wrongAnswers);
//    }


//}
//{
//    if(IsNextScene == true)
//    {
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//    }
//    //GlobalInstance.Instance.Count += 1;
//}

//private void Start()
//{
//GlobalInstance.Instance.Count += 1;
//  Debug.Log(GlobalInstance.Instance.Count);
