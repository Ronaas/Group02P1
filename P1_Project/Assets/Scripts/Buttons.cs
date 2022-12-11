
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void SceneDelay()
    { 
        Invoke("LoadScene", 1f);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        GlobalInstance.Instance.Count += 1;
    }

    private void Start()
    {
        //GlobalInstance.Instance.Count += 1;
        Debug.Log(GlobalInstance.Instance.Count);
    }
}

















