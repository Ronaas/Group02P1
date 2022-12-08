using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Question_BehaviourSetter
{
    [SerializeField] private bool _isCorrect;
    public bool IsCorrect { get { return _isCorrect; } }


}

[CreateAssetMenu(fileName = "Set Question Truth")]
public class Question : ScriptableObject
{
    [SerializeField] Question_BehaviourSetter[] QuestionDefined = null;



}
