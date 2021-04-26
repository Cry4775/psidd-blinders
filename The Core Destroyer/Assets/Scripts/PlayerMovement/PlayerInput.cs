// GENERATED AUTOMATICALLY FROM 'Assets/Core/Input Action Assets/PlayerInput/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""9e198bf8-b589-450f-bf5d-b038aea531a0"",
            ""actions"": [
                {
                    ""name"": ""MoveInput"",
                    ""type"": ""Value"",
                    ""id"": ""f6c72adc-e105-43d0-a43b-27cde5421ff6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""91ac13e2-0dfa-4826-85b7-f14e16bf88dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dab80862-f0be-46d0-af78-ccd6a5f7627e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3c6a301c-281b-4eef-9591-a27947bbbf16"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6f9e2f5e-3e9c-42f3-82d8-b83a21cb7069"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bfdcfd68-44d3-48ed-b78d-b0ba487442b1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftJoystick"",
                    ""id"": ""1783a0d4-8ac9-4e3b-b8da-859b1e72e6f1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""997623d8-bfa9-44e0-a967-e21302249965"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e6aed364-1171-4cb7-86f8-39e553d71b37"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8e6e71f6-e978-4402-8cd7-304b9d6f4b80"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d52f3582-6a8a-40d7-96b4-b9cebc0c32ea"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPAD"",
                    ""id"": ""a4c8197d-a554-41ef-b0ca-f2f93dda7be2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""11729b06-96c3-460b-8d15-3fb4170e87d5"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a3273783-0fce-463d-967a-b8631c41aa80"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""186fb1f7-e77a-43ad-b7c7-22039c3cff02"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""971cf830-9fb7-4539-8ebe-70561402741e"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Buttons"",
            ""id"": ""7cadc654-09d3-4410-8b45-4287a32916d8"",
            ""actions"": [
                {
                    ""name"": ""Attack/Interact"",
                    ""type"": ""Button"",
                    ""id"": ""5226abf8-b034-42f1-8674-b34cf5840314"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseSkill"",
                    ""type"": ""Button"",
                    ""id"": ""30728635-aa8b-4db9-8d11-31adc571a559"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""b30ba017-e787-4d50-a795-1f78f0264449"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CycleSkills"",
                    ""type"": ""Button"",
                    ""id"": ""d0ea7459-7c3b-4e00-a03c-f43fec1a7729"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CycleWeapons"",
                    ""type"": ""Button"",
                    ""id"": ""5ee60d57-f6d8-420e-b42a-0185dad18903"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UsePotion"",
                    ""type"": ""Button"",
                    ""id"": ""75c238b7-f10d-4297-a51c-985e7ce53ccc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CyclePotions"",
                    ""type"": ""Button"",
                    ""id"": ""e763d8ac-9b1e-4dd3-8a51-311abeb455c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""8f0efc54-1a0a-44a7-acd8-eae5db9f56e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Map"",
                    ""type"": ""Button"",
                    ""id"": ""6eaecdd9-d246-4fc3-9295-8d1fe4732da5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7438d1ed-23ec-4747-bcc0-1d84837db723"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack/Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43921685-6179-45a1-a80c-dcac7ade09f7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack/Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07959bca-1e5c-40b0-a36b-ffe8667bea07"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseSkill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bbbc994-8cbf-4e16-ba63-3b739cc1f1b3"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseSkill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9eb4b071-65f9-459c-ab4b-6972cf5448c7"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94774afc-f969-449e-bc02-22611dadfa76"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2597f941-b883-4ed8-873b-67d2b69c4c65"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CycleSkills"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffc4e828-6679-418d-a467-bb34afbe1300"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CycleSkills"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b961f61-a422-45d4-a901-f2acd806577f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CycleWeapons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fef0daf2-c0ba-4c44-9dac-7286c881fb29"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CycleWeapons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ee9b342-29b0-4987-a7a6-19cb7cacbaa6"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UsePotion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d21e7d0-d569-411d-b0e9-d4083b09a0b3"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UsePotion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd36e118-25c9-47c0-98e2-1407d3cc463b"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CyclePotions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a038bfe-b07e-4277-8ae5-23687b42373d"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CyclePotions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f824d20c-e4fb-4b99-9a04-499038e14fa2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""422bf397-8c15-4798-83cf-a7043ca80a21"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6de18a5-f399-44dd-8a56-bc7a854c4c96"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc0ecad4-74a3-4929-b6f0-e877f8357e9c"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_MoveInput = m_Movement.FindAction("MoveInput", throwIfNotFound: true);
        // Buttons
        m_Buttons = asset.FindActionMap("Buttons", throwIfNotFound: true);
        m_Buttons_AttackInteract = m_Buttons.FindAction("Attack/Interact", throwIfNotFound: true);
        m_Buttons_UseSkill = m_Buttons.FindAction("UseSkill", throwIfNotFound: true);
        m_Buttons_Inventory = m_Buttons.FindAction("Inventory", throwIfNotFound: true);
        m_Buttons_CycleSkills = m_Buttons.FindAction("CycleSkills", throwIfNotFound: true);
        m_Buttons_CycleWeapons = m_Buttons.FindAction("CycleWeapons", throwIfNotFound: true);
        m_Buttons_UsePotion = m_Buttons.FindAction("UsePotion", throwIfNotFound: true);
        m_Buttons_CyclePotions = m_Buttons.FindAction("CyclePotions", throwIfNotFound: true);
        m_Buttons_Pause = m_Buttons.FindAction("Pause", throwIfNotFound: true);
        m_Buttons_Map = m_Buttons.FindAction("Map", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_MoveInput;
    public struct MovementActions
    {
        private @PlayerInput m_Wrapper;
        public MovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveInput => m_Wrapper.m_Movement_MoveInput;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @MoveInput.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveInput;
                @MoveInput.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveInput;
                @MoveInput.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveInput;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveInput.started += instance.OnMoveInput;
                @MoveInput.performed += instance.OnMoveInput;
                @MoveInput.canceled += instance.OnMoveInput;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Buttons
    private readonly InputActionMap m_Buttons;
    private IButtonsActions m_ButtonsActionsCallbackInterface;
    private readonly InputAction m_Buttons_AttackInteract;
    private readonly InputAction m_Buttons_UseSkill;
    private readonly InputAction m_Buttons_Inventory;
    private readonly InputAction m_Buttons_CycleSkills;
    private readonly InputAction m_Buttons_CycleWeapons;
    private readonly InputAction m_Buttons_UsePotion;
    private readonly InputAction m_Buttons_CyclePotions;
    private readonly InputAction m_Buttons_Pause;
    private readonly InputAction m_Buttons_Map;
    public struct ButtonsActions
    {
        private @PlayerInput m_Wrapper;
        public ButtonsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @AttackInteract => m_Wrapper.m_Buttons_AttackInteract;
        public InputAction @UseSkill => m_Wrapper.m_Buttons_UseSkill;
        public InputAction @Inventory => m_Wrapper.m_Buttons_Inventory;
        public InputAction @CycleSkills => m_Wrapper.m_Buttons_CycleSkills;
        public InputAction @CycleWeapons => m_Wrapper.m_Buttons_CycleWeapons;
        public InputAction @UsePotion => m_Wrapper.m_Buttons_UsePotion;
        public InputAction @CyclePotions => m_Wrapper.m_Buttons_CyclePotions;
        public InputAction @Pause => m_Wrapper.m_Buttons_Pause;
        public InputAction @Map => m_Wrapper.m_Buttons_Map;
        public InputActionMap Get() { return m_Wrapper.m_Buttons; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ButtonsActions set) { return set.Get(); }
        public void SetCallbacks(IButtonsActions instance)
        {
            if (m_Wrapper.m_ButtonsActionsCallbackInterface != null)
            {
                @AttackInteract.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnAttackInteract;
                @AttackInteract.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnAttackInteract;
                @AttackInteract.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnAttackInteract;
                @UseSkill.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnUseSkill;
                @UseSkill.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnUseSkill;
                @UseSkill.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnUseSkill;
                @Inventory.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnInventory;
                @CycleSkills.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnCycleSkills;
                @CycleSkills.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnCycleSkills;
                @CycleSkills.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnCycleSkills;
                @CycleWeapons.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnCycleWeapons;
                @CycleWeapons.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnCycleWeapons;
                @CycleWeapons.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnCycleWeapons;
                @UsePotion.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnUsePotion;
                @UsePotion.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnUsePotion;
                @UsePotion.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnUsePotion;
                @CyclePotions.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnCyclePotions;
                @CyclePotions.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnCyclePotions;
                @CyclePotions.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnCyclePotions;
                @Pause.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnPause;
                @Map.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnMap;
                @Map.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnMap;
                @Map.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnMap;
            }
            m_Wrapper.m_ButtonsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AttackInteract.started += instance.OnAttackInteract;
                @AttackInteract.performed += instance.OnAttackInteract;
                @AttackInteract.canceled += instance.OnAttackInteract;
                @UseSkill.started += instance.OnUseSkill;
                @UseSkill.performed += instance.OnUseSkill;
                @UseSkill.canceled += instance.OnUseSkill;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @CycleSkills.started += instance.OnCycleSkills;
                @CycleSkills.performed += instance.OnCycleSkills;
                @CycleSkills.canceled += instance.OnCycleSkills;
                @CycleWeapons.started += instance.OnCycleWeapons;
                @CycleWeapons.performed += instance.OnCycleWeapons;
                @CycleWeapons.canceled += instance.OnCycleWeapons;
                @UsePotion.started += instance.OnUsePotion;
                @UsePotion.performed += instance.OnUsePotion;
                @UsePotion.canceled += instance.OnUsePotion;
                @CyclePotions.started += instance.OnCyclePotions;
                @CyclePotions.performed += instance.OnCyclePotions;
                @CyclePotions.canceled += instance.OnCyclePotions;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Map.started += instance.OnMap;
                @Map.performed += instance.OnMap;
                @Map.canceled += instance.OnMap;
            }
        }
    }
    public ButtonsActions @Buttons => new ButtonsActions(this);
    public interface IMovementActions
    {
        void OnMoveInput(InputAction.CallbackContext context);
    }
    public interface IButtonsActions
    {
        void OnAttackInteract(InputAction.CallbackContext context);
        void OnUseSkill(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnCycleSkills(InputAction.CallbackContext context);
        void OnCycleWeapons(InputAction.CallbackContext context);
        void OnUsePotion(InputAction.CallbackContext context);
        void OnCyclePotions(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnMap(InputAction.CallbackContext context);
    }
}
