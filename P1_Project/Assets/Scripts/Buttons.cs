
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
[ExecuteInEditMode]

public class Buttons : MonoBehaviour
{
    public bool trueAnswer;
    public GameObject CorrectAnswer;
    public GameObject WrongAnswer;
    //public GameObject WrongAnswer2;
    //public GameObject WrongAnswer3;
    // der er i denne jeg i sidste ende skal formå at skifte imellem scenerne samtidigt men at genere data i. 
    //public bool IsNextScene = false;
    //public bool buttonPressed;

    [SerializeField]
    public QuestionResults questionResults;
    public void SceneDelay()
    {
        Invoke("LoadScene", 1f);
    }
    public void LoadScene()
    {
        if (CorrectAnswer == trueAnswer)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            questionResults.currentscene += 1;
            questionResults.correctAnswers += 1;
            Debug.Log("NR of current question");
            Debug.Log(questionResults.currentscene);
            Debug.Log("NR of correct answers");
            Debug.Log(questionResults.correctAnswers);
        } 
        if(CorrectAnswer!= trueAnswer)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            questionResults.currentscene += 1;
            questionResults.wrongAnswers += 1;
            Debug.Log("NR of current question");
            Debug.Log(questionResults.currentscene);
            Debug.Log("NR of Wrong answers");
            Debug.Log(questionResults.wrongAnswers);
        }
       

    }
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
    //}
}