using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Made by CRY
public class PlayerMovement : MonoBehaviour
{
    // Brackeys that explains how it works https://www.youtube.com/watch?v=Pzd8NhcRzVo&t=685s
    
    #region REFERENCES

        // For the Input Action Asset in the "Core/Input Action Assets" folder
        PlayerInput playerInput; 

        // For the player Rigidbody2D
        Rigidbody2D rb2D;

        

    #endregion

    #region FLOATS

    [Tooltip("How fast the player moves")]
        public float _speed = 12f;

    #endregion

    #region VECTORS

        // Vector for player movement
        Vector2 moveVector;

    #endregion

    
    void Awake ()
    {   
        #region Player Input Setup

            // Makes a new PlayerInput = to playerInput
            playerInput = new PlayerInput();

            /* 
                When a Button/Joystick movement that is bound to the MoveInput action is 
                pressed/active call the function OnMovementChanged
            */
            playerInput.Movement.MoveInput.performed += OnMovementChanged;

            /* 
                When a Button/Joystick movement that is bound to the MoveInput action is 
                no longer pressed call the function OnMovementChanged
            */
            playerInput.Movement.MoveInput.canceled += OnMovementChanged;

        #endregion

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
        rb2D.MovePosition((Vector2) rb2D.position + moveVector * _speed * Time.fixedDeltaTime);
    }

    
}
