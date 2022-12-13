using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable()]
[CreateAssetMenu(fileName = "Question Info", menuName = "Results from Test")]
public class QuestionResults : ScriptableObject
{
    [SerializeField] private GameObject correctAnswer;
    public GameObject CorrectAnswer { get { return correctAnswer; } }

    [SerializeField] public List<GameObject> wrongAnswer;
    public List<GameObject> WrongAnswer { get { return wrongAnswer; } }

    
    
    public int currentscene = 0;
    public int correctAnswers = 0;
    public int wrongAnswers = 0;
    // public bool isCorrectAnswer = false;

}
