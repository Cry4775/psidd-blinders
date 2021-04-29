using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Made by CRY
public class PlayerMovement : MonoBehaviour
{
    // Brackeys that explains how it works https://www.youtube.com/watch?v=Pzd8NhcRzVo&t=685s
    
    #region REFERENCES
    PlayerInput playerInput; 
    Rigidbody2D rb2D;
    PlayerStats playerStats;
    


    #endregion

    #region FLOATS

    public float speed;

    #endregion

    #region VECTORS

        // Vector for player movement
        Vector2 moveVector;

    #endregion

    
    void Awake ()
    {   

        playerInput = new PlayerInput();

        playerInput.Movement.MoveInput.performed += OnMovementChanged;
        playerInput.Movement.MoveInput.canceled += OnMovementChanged;

        rb2D = GetComponent<Rigidbody2D>();
    }

    #region Player Input Setup

    // This function is called when the object becomes enabled or active
    void OnEnable ()
    {   
        // Enables playerInput controls
        playerInput.Enable();
    }

    // This function is called when the object becomes disabled or inactive
    void OnDisable ()
    {
        // Disables playerInput controls
        playerInput.Disable();
    }

    
    // This function helps detect whether or not the moveVectors x or y values are = to 1 or -1 
    void OnMovementChanged (InputAction.CallbackContext context)
    {   
        // Creates a new variable to store the Vector2 value of the MoveInputs Vector2 value
        var direction = context.ReadValue<Vector2>();

        if (direction.x != 0 || direction.y != 0) // If the x or y values of the direction are not 0
        {
            // Sets the moveVector value = to the direction value
            moveVector = direction;
        }
        else if (direction.x == 0 && direction.y == 0) // If the x and y values of the direction are = to 0
        {
            // Sets the moveVector value = to Vector2.zero
            moveVector = Vector2.zero;
        }
    }

    #endregion
    
    void FixedUpdate ()
    {
        // Moves the Rigidbody in the direction of moveVectors x and y by _speed 

        rb2D.MovePosition((Vector2) rb2D.position + moveVector * speed * Time.fixedDeltaTime);
    }

    
}
