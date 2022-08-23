using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Set torque amount
    [SerializeField] float torqueAmount = 1f;
    //Set boosted speed
    [SerializeField] float boostSpeed = 30f;
    //Set base speed
    [SerializeField] float baseSpeed = 20f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    //Set can move to true
    bool canMove = true;
    
    void Start()
    {
        //Set rb2d equals Rigidbody2D
        rb2d = GetComponent<Rigidbody2D>();
        //Set surface effector 2d
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        //If canMove equals true it will:   
        if(canMove == true)
        {
            //If left arrow is being pressed it will:
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                //Add torque to the rigidbody2D
                rb2d.AddTorque(torqueAmount);
            }
            //If right arrow is being pressed it will:
            else if(Input.GetKey(KeyCode.RightArrow))
            {
                //Add negative torque to the rigidbody2D
                rb2d.AddTorque(-torqueAmount);
            }
            //Calls RespondToBoos method
            RespondToBoost();
        }
    }

    public void DisableControls()
    {
        //Set can move to false
        canMove = false;
    }

    void RespondToBoost()
    {
        //If up arrow is being pressed it will:
        if(Input.GetKey(KeyCode.UpArrow))
        {  
            //Sets the surface effector 2d speed to boosted speed
            surfaceEffector2D.speed  = boostSpeed;
        }
        else
        {
            //Sets the surface effector 2d speed to base speed
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
