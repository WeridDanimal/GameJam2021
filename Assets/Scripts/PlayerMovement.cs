using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls controls;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    public float ButtonCooler=0.5f ; // Half a second before reset
    public int ButtonCount= 0;
    bool dashCooldown = false;
    // Update is called once per frame\

    //vector2 stores x and y values
    Vector2 movement;


    private void Awake()
    {
        controls = new PlayerControls();
        controls.Gameplaymap.Slide.performed += ctx=> Slide();
        controls.Gameplaymap.Move.performed += ctx => movement = ctx.ReadValue<Vector2>();
        controls.Gameplaymap.Move.canceled += ctx => movement = Vector2.zero;

    }

    void Slide()
    {
        if (dashCooldown == false)
        {
            float dashAmount = 75f;
            //print("player slides");
            Vector2 m = new Vector2(movement.x, movement.y) * Time.deltaTime * moveSpeed * dashAmount;
            transform.Translate(m, Space.World);
            Invoke("ResetCooldown", 2.0f);
            dashCooldown = true;
        }
    }

    void ResetCooldown()
    {
        dashCooldown = false;
    }

    private void Update()
    {
        Vector2 m = new Vector2(movement.x, movement.y)*Time.deltaTime*moveSpeed;
        transform.Translate(m, Space.World);

    }

    private void FixedUpdate()
    {

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
