using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Buttons : MonoBehaviour
{
    public bool Ischanged = false;
    public int AskedQuestions;
    
    public void SceneDelay()
    {
        Invoke("LoadScene", 1f);
    
    }
    public void addInt()
    {
        AskedQuestions = AskedQuestions + 1;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(AskedQuestions);
            
        
    }



    
    
} 










