using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Get the Audio Source component
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Check for the "M" key press
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Toggle the mute state
            audioSource.mute = !audioSource.mute;
        }
    }
}
