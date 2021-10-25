using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls controls;
    public float moveSpeed = 5f;
    public bool isCollide = false;
    public float jumpSpeed = 5;

    public Rigidbody2D rb;                  // player access rigidbody

    /* layers */
    // Ground       = 6
    // Jump Only    = 7
    // Slide Only   = 8
    // Both         = 9
    // Neither      = 10

    public float ButtonCooler=0.5f ;        // Half a second before reset
    public int ButtonCount= 0;
    bool dashCooldown = false;
    // Update is called once per frame\

    //vector2 stores x and y values
    Vector2 movement;

    private void Start()
    {
        gameObject.layer = 6; // initialize to ground
    }
    private void Awake()
    {
        controls = new PlayerControls();
        // Lambda Expression - action (calls) context (go to) expression
        // controls.Gameplaymap.Slide.performed    += ctx=> Slide();

        controls.Gameplaymap.Slide.performed    += ctx => Slide(true);
        controls.Gameplaymap.Slide.canceled     += ctx => Slide(false); 
        controls.Gameplaymap.Move.performed     += ctx => movement  = ctx.ReadValue<Vector2>();
        controls.Gameplaymap.Move.canceled      += ctx => movement  = Vector2.zero;

        //new code: implement Jump function
        controls.Gameplaymap.Jump.performed += ctx => Jump(true);
        controls.Gameplaymap.Jump.canceled += ctx => Jump(false);
    }

    void Jump(bool isJumping)
    {
        //jumpHeight=0
        if(isJumping)
        {
            gameObject.layer = 7;
        }
        else
        {
            gameObject.layer = 6;
        }
    }
    void Slide(bool isSliding)
    {
        /* testing collision
        if (dashCooldown == false)
        {
            float dashAmount = 75f;
            //print("player slides");
            //Vector2 m = new Vector2(movement.x, movement.y) * Time.deltaTime * moveSpeed * dashAmount;
            //transform.Translate(m, Space.World);
            Invoke("ResetCooldown", 2.0f);
            dashCooldown = true;
        }*/
        
        if (isSliding)
        {
            gameObject.layer = 8; // layer Slide Only
            moveSpeed = 5f;
        }
        else
        {
            gameObject.layer = 6; // layer Ground
            moveSpeed = 20f;
        }
        print(gameObject.layer);
        //Daniel's comment: I just realized. If the player lets go of ths slide button, it will 
        //switch to 6. This is bad because if the player lets go while being in an obstacle they can be on,
        //then they will be kicked off.

        //proposal for change: 



    }

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checks if it console outputs trigger when player is touching object
        print("Trigger");

    }
    */
        //New code written by Daniel:
        /*private void OnCollisionExit(Collider2D collision)
        {
            //If player is out of bounds of any obstacle, 
            //gameObject.layer=6
        }
        */
    void ResetCooldown()
    {
        dashCooldown = false;
    }

    private void Update()
    {
        // movement moved to fixed update and using rigidbody with velocity instead of transform
        // Vector2 m = new Vector2(movement.x, movement.y) * Time.deltaTime * moveSpeed;
        // transform.Translate(m, Space.World);
    }

    private void FixedUpdate()      // consistent frame rate, put physics here
    {
        rb.velocity = new Vector2(movement.x, movement.y) * moveSpeed;
        // future idea
        //      raytrace to check what kind of obstacle
        //      change layer depth based on what action doing (if pass obstacle condition)
    }

    private void OnEnable()
    {
        controls.Gameplaymap.Enable();
    }

 
    private void OnDisable()
    {
        controls.Gameplaymap.Disable();
    }
    //not wise to put anything relying on physics to update() since the framerate could change any time
    //Update() is used to register inputs





}
