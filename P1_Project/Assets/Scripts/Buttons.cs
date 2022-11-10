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

void update()
{
IEnumerator DelayedSceneChange()
    {
      yield return new WaitForSecondsRealtime(10f);
      
    
      {
        StartCoroutine(DelayedSceneChange());
      }
      
    }


}
}









