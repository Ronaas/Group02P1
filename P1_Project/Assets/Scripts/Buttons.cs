using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Buttons : MonoBehaviour
{

    public bool trueAnswer;
    public GameObject CorrectAnswer;
    public GameObject WrongAnswer;

    [SerializeField]
    public QuestionResults questionResults;
    public void SceneDelay()
    {
        Invoke("LoadScene", 1f);
    }
    public void LoadScene()
    {

        //notice.NoticeClick(someObject);
        //Debug.Log("Nr of wrong answers");
        //Debug.Log("Nr of current question");
        //Debug.Log("Ne of correct answers");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
        
        
//        if (CorrectAnswer)
//        {
//            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//            questionResults.sceneNR += 1;   
//            questionResults.correctAnswers += 1;
            
//            Debug.Log("NR of current question");
//            Debug.Log(questionResults.sceneNR);

//            Debug.Log("NR of correct answers");
//            Debug.Log(questionResults.correctAnswers);
//        }
//        if (CorrectAnswer != trueAnswer)
//        {
//            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//            questionResults.sceneNR += 1;
//            questionResults.wrongAnswers += 1;

//            Debug.Log("NR of current question");
//            Debug.Log(questionResults.sceneNR);

//            Debug.Log("NR of Wrong answers");
//            Debug.Log(questionResults.wrongAnswers);
//        }
//    }
//}


//[SerializeField] private ButtonPressNotice notice;
//public ButtonPressNotice  Notice { get { return Notice; } }


//public UnityEngine.UI.Button someObject;

////[SerializeField] QuestionExpert expert;
////[SerializeField] QuestionResults results;

//void Start()
//{
//    someObject = gameObject.GetComponent<UnityEngine.UI.Button>();
//}

////private void Getbuttons()
////{
////    someObjects = Buttons.GetComponents<someObjects>();
////}




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


        
