using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

[Serializable]
[CreateAssetMenu(fileName = "Question Info", menuName = "Results from Test")]
public class QuestionResults : ScriptableObject
{
    [SerializeField] public int correctAnswer;
    public int CorrectAnswer { get { return correctAnswer; } }


    [SerializeField] public int wrongAnswer;
    public int WrongAnswer { get { return wrongAnswer; } }


    [SerializeField] public int sceneNR;
    public int SceneNR { get { return sceneNR; } }


    public int correctAnswers = 0;
    public int wrongAnswers = 0;
    public int thisScenenNR = 0;

}
