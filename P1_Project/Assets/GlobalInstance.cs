using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInstance : MonoBehaviour
{
    public static GlobalInstance Instance;

    public int Count = 0;

    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        
    }
}
