using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Components to be referenced
    private Rigidbody2D _rb2d;
    private Animator _animator;

    //Vectors for movement and orientation
    private Vector2 _direction;
    private Vector2 _orientation;

    //the different movement speeds
    public float _walkSpeed = 10f;
    //public float _dashSpeed = 5f;
    //public float _sprintSpeed = 15f;

    //speed currently effective
    //public float _currentSpeed;

    void Start()
    {
        // set up Rigidbody for use in the script
        _rb2d = GetComponent<Rigidbody2D>();
        // get the Animator as a child of the PlayerRig where we planted our script
        _animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (_direction.magnitude > 0) //if magnitude is above 0, the player is moving
        {


            // use animators for the corresponding movement direction
            _animator.SetFloat("SpeedX", _direction.x);
            _animator.SetFloat("SpeedY", _direction.y);
            _animator.SetBool("isMoving", true);
            FlipPlayer();

        }

        else //if magnitude is below 0, the player is not moving
        {

            
            _animator.SetBool("isMoving", false);

        }

    }

    private void FlipPlayer()
    {
        // character rotates by 180 degrees if he walks to the left (= less than zero velocity on the x axis)
        if (_direction.x < 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
        }
        // character rotates back if he walks towards the right 
        else if (_direction.x > 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        }
    }

    private void FixedUpdate()
    {
        _rb2d.velocity = _direction.normalized * _walkSpeed;
    }



}
