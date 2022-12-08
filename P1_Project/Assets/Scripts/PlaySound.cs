using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaySound : MonoBehaviour
{
    private AudioSource _audioSource;
    public float timeBetweenPlays = 10f;

    // Start is called before the first frame update
    private void Start()
    {
        // Kalder sounddPlayer hvert timeBetweenPlays sekund (base af 10)
        InvokeRepeating("sounddPlayer", timeBetweenPlays, timeBetweenPlays);

        // får fat på audiosource, spiller den hvis den kan finde den.
        _audioSource = GetComponent<AudioSource>();
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
