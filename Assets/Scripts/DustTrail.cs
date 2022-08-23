using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
        [SerializeField] ParticleSystem dustEffect;
    
    void OnCollisionEnter2D(Collision2D other) 
    {
        //When entering collision with ground it will:
        if(other.gameObject.tag == "Ground")
        {
            //Play the dustEffect
            dustEffect.Play();
        }
    }
    
    void OnCollisionExit2D(Collision2D other) 
    {
        //When exiting collision with ground it will:
        if(other.gameObject.tag == "Ground")
        {
            //Stops dustEffect
            dustEffect.Stop();
        }
    }
}
