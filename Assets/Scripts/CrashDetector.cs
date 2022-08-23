using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{  
    //Boolean to see if the caracther is dead
    bool dead = false;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    void OnTriggerEnter2D(Collider2D other) 
    {
        //If collides with ground and is not dead it will:
        if(other.tag == "Ground" && dead == false)
        {
            //Call the DisableControls method from player controller
            FindObjectOfType<PlayerController>().DisableControls();
            //Play the crashEffect
            crashEffect.Play();
            //Get the AudioSource and play it one time
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            //Invokes the reload scene after 1 second
            Invoke("ReloadScene", 1f);
            //Dead boolean equals true
            dead = true;
        }
    }

    void ReloadScene()
    {
        //Reload the scene
        SceneManager.LoadScene(0);
    }
}
