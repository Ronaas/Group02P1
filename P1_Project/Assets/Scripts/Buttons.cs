using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
      SceneManager.LoadScene(sceneName);
    }
    IEnumerator DelayedSceneChange(float delay, string sceneName)
    {
      yield return new WaitForSecondsRealtime(delay);
      LoadScene(sceneName);
    
      StartCoroutine(DelayedSceneChange(20f, sceneName));
    }
}









