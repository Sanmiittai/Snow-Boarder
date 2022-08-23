using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    //
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            //Play the finishEffect
            finishEffect.Play();
            //Play the AudioSource
            GetComponent<AudioSource>().Play();
            //Invoke ReloadScene with 1 second delay
            Invoke("ReloadScene", 1f);
        }
    }

    void ReloadScene()
    {
        //Reload scene
        SceneManager.LoadScene(0);
    }
}
