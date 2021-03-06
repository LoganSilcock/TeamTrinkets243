﻿using UnityEngine;
using System.Collections;
using UnityEngine.Audio;


public class PlatformerCharacter2D : MonoBehaviour
{
    public AudioClip jumpSound;
    private AudioSource source;

    private bool facingRight = true;
    // For determining which way the player is currently facing.

    [SerializeField] private float maxSpeed = 10f;
    // The fastest the player can travel in the x axis.
    [SerializeField] private float jumpForce = 700f;
    // Amount of force added when the player jumps.

    [SerializeField] private bool airControl = false;
    // Whether or not a player can steer while jumping;
    [SerializeField] private LayerMask whatIsGround;
    // A mask determining what is ground to the character

    private Transform groundCheck;
    // A position marking where to check if the player is grounded.
    private float groundedRadius = .6f;
    // Radius of the overlap circle to determine if grounded
    private bool grounded = false;
    // Whether or not the player is grounded.
    private Transform ceilingCheck;
    // A position marking where to check for ceilings
    //private float ceilingRadius = .01f;
    // Radius of the overlap circle to determine if the player can stand up
    private Animator anim;
    // Reference to the player's animator component.

    bool doubleJump = false;

    private void Awake()
    {
        // Setting up references.
        groundCheck = transform.Find("GroundCheck");
        ceilingCheck = transform.Find("CeilingCheck");
        anim = GetComponent<Animator>();

        source = GetComponent<AudioSource>();
    }


    private void FixedUpdate()
    {
        // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundedRadius, whatIsGround);
        anim.SetBool("Ground", grounded);

        // Set the vertical animation
        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

        if (grounded)
            doubleJump = false;
    }

    /**
    private void OnTriggerEnter(BoxCollider2D other)
    {
        if (other.tag == "Platform")
            grounded = true;
    }

    private void OnTriggerExit(BoxCollider2D other)
    {
        if (other.tag == "Platform")
            grounded = true;
    }
    */

    public void Move(float move, bool jump)
    {
        //only control the player if grounded or airControl is turned on
        if (grounded || airControl)
        {
            anim.SetFloat("Speed", Mathf.Abs(move)); // The Speed animator parameter is set to the absolute value of the horizontal input.

            GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);  // Move the character

            // If the input is moving the player right and the player is facing left...
            if (move > 0 && !facingRight)
                Flip();
                // Otherwise if the input is moving the player left and the player is facing right...
            else if (move < 0 && facingRight)
                Flip();
        }
        // If the player should jump...
        if ((grounded || !doubleJump) && jump)// && anim.GetBool("Ground"))
        {
            // Add a vertical force to the player.
            anim.SetBool("Ground", false);

            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
            source.PlayOneShot(jumpSound, 1.0f);

            if (!grounded)
                doubleJump = true;
        }
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}