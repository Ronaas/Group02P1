using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaySound : MonoBehaviour
{
    private AudioSource _audioSource;

    private void sounddPlayer()
    {

        if (_audioSource == null)
        {
            Debug.LogError("There is no sound connected to the Question in the set");
        }
        else
        {
            _audioSource = GetComponent<AudioSource>();
            _audioSource.Play();
        }
    }

}
