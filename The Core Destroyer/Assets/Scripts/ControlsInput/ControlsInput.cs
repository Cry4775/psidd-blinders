using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlsInput : MonoBehaviour
{
    PlayerInput controls;

    public bool invIsOpen = false;

    void Awake ()
    {
        // Makes a new PlayerInput = to controls
        controls = new PlayerInput();

        /* 
                When a Button that is bound to any of the Buttons Action map actions is 
                pressed call the function after the =>. (Exactly the same for all the others too)
        */
        controls.Buttons.AttackInteract.performed += ctx => AttackOrInteract();

        controls.Buttons.Inventory.performed += ctx => Inventory();

        controls.Buttons.UsePotion.performed += ctx => UsePotion();

        controls.Buttons.CyclePotions.performed += ctx => CyclePotions();

        controls.Buttons.UseSkill.performed += ctx => UseSkill();

        controls.Buttons.CycleSkills.performed += ctx => CycleSkills();

        controls.Buttons.CycleWeapons.performed += ctx => CycleWeapons();

        controls.Buttons.Pause.performed += ctx => Pause();

        controls.Buttons.Map.performed += ctx => Map();
    }

    void AttackOrInteract ()
    {
        Debug.Log("Attacking");
    }

    void Inventory ()
    {
        if (!invIsOpen)
        {
            Debug.Log("Opening Inventory");
            invIsOpen = true;
        }
        else if (invIsOpen)
        {
            Debug.Log("Closing Inventory");
            invIsOpen = false;
        }
    }

    void UseSkill ()
    {
        Debug.Log("Using skill");
    }

    void CycleSkills ()
    {
        Debug.Log("Swapping to next skill");
    }

    void UsePotion ()
    {
        Debug.Log("Using Potion");
    }

    void CyclePotions ()
    {
        Debug.Log("Swapping to next potion");
    }

    void CycleWeapons ()
    {
        Debug.Log("Swapping to next weapon");
    }

    void Pause ()
    {
        Debug.Log("Pausing Game");
    }

    void Map ()
    {
        Debug.Log("Opening map");
    }

    void OnEnable ()
    {
        controls.Buttons.Enable();
    }

    void OnDisable ()
    {
        controls.Buttons.Disable();
    }


}
