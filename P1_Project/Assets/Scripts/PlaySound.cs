using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaySound : MonoBehaviour
{
    private AudioSource _audioSource;
    public float timeBetweenPlays = 10f; //der mangler stadig slowdown på tiden.


    //[SerializeField]
    //int questionsNR;
    //QuestionExpert QuestionSystem;
    // Start is called before the first frame update
    private void Start()
    {
       
        InvokeRepeating("sounddPlayer", timeBetweenPlays, timeBetweenPlays);  // Kalder sounddPlayer hvert timeBetweenPlays sekund (base af 10)
        _audioSource = GetComponent<AudioSource>(); // får fat på audiosource, spiller den hvis den kan finde den.
        //QuestionSystem = FindObjectOfType<QuestionExpert>();
        //questionsNR = QuestionSystem.CurrentQuestions;
    }

    private void sounddPlayer()
    {
        // hvis den ikke har en audiosource printer denne i debug log
        if (_audioSource == null)
        {
            Debug.LogError("There is no sound connected to the Question in the set");
        }
        else
        {
            _audioSource.Play();
        }
    }

}
