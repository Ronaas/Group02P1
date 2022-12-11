using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AgeSelect : MonoBehaviour
{
    // Q1 S1 is text
    public string scene;

    // method that opens a variable string: scene by ToString

    public void OpenScene()
        {
            SceneManager.LoadScene(scene.ToString());
        }
  
}
