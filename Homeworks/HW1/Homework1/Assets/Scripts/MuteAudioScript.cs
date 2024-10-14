using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudioScript : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            Debug.LogError("No AudioSource found on the Main Camera!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ToggleMute();
        }
    }

    void ToggleMute()
    {
        if (audioSource != null)
        {
            audioSource.mute = !audioSource.mute;
            
            Debug.Log("Audio Muted: " + audioSource.mute);
        }
    }
}
