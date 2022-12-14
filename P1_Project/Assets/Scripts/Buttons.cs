using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Buttons : MonoBehaviour
{

    [SerializeField]
    public QuestionResults questionResults;
    public void SceneDelay()
    {
        Invoke("LoadScene", 1f);
    }
    public void LoadScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
        
 