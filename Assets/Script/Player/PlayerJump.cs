using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    private Animator animator;

    //------------------- NOT USED AT THE MOMENT-------------------------------------------------------------------------------------------------------------
    [SerializeField] AnimationCurve jumpCurve; //curve to define the jumping

    [SerializeField] float jumpHeight = 3; // to be able to influence jump height in inspector

    [SerializeField] float jumpDuration = 3f; // to be able to influence jump duration

    private Transform graphics;
    private float jumpTimer; // = x value of the jump curve

    //--------------------------------------------------------------------------------------------------------------------------------------------------------------

    private bool isJumping = false;

    private void Awake()
    {
        //graphics = transform.Find("Graphics");
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        //triggering Jump ability when pressing Spacebar
        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            isJumping = true;
            animator.SetBool("isJumping", true);

        }
            Debug.Log("Jumping Bool is set to " + isJumping);
    }

    


    
    //------------------- NOT USED AT THE MOMENT-------------------------------------------------------------------------------------------------------------
    private void TriggerJumpCurve()
    {
        // implementing the timer
        if (jumpTimer < jumpDuration) // as long as timer is not full yet...
        {
            jumpTimer += Time.deltaTime; // add running time to timer

            //progression / maximum --> gives us a percentage value: how much of the overall timer has already been spent
            float y = jumpCurve.Evaluate(jumpTimer / jumpDuration); // checks where on the curve we are at the current jump timer;  

            graphics.localPosition = new Vector3(transform.localPosition.x, y * jumpHeight, transform.localPosition.z); // move graphics (=the player sprite) vertically

            Debug.Log(y); // to print out position on curve every frame

        }
        else
        {
            jumpTimer = 0f;
        }
    }
}
