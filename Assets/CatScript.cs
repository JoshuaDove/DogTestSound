using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour {

    // This will reference what is supposed to be played when the user clicks on the cube
    public AudioClip soundfx;

    // Refers to the file stored in the audiosource component.
    private AudioSource audioSource;

    void Start() // Does something as soon as the program is executed
    {
        // Retrieves audiosource data including the file that's currently stored within it
        audioSource = gameObject.GetComponent<AudioSource>();


    }

    void OnMouseOver()// a function that does something when a mouse click is given as input
    {
        // An if statement that executes the action between the brackets 
        //when the left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.enabled = true;
            if (!audioSource.isPlaying)// detects if there's something to be played in the audio source
            {
                // This statement is what will be used to assign the sound fx variable to the audiosource
                // linking the audio and game object together
                audioSource.clip = soundfx;
                //Plays the sound file stored in the audiosource
                audioSource.Play();
            }
        }
    }
}
