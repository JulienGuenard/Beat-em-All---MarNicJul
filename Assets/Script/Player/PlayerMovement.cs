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
    public float _runSpeed = 10f;
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

    }

    private void FixedUpdate()
    {
        _rb2d.velocity = _direction.normalized * _runSpeed;
    }



}
