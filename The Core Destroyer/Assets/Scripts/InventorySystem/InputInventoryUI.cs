// GENERATED AUTOMATICALLY FROM 'Assets/Core/Input Action Assets/Inventory/InputInventoryUI.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputInventoryUI : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputInventoryUI()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputInventoryUI"",
    ""maps"": [
        {
            ""name"": ""Inventory UI navigation"",
            ""id"": ""058ba5b0-6ace-455d-9d28-4c7342d6fdbf"",
            ""actions"": [
                {
                    ""name"": ""Equip"",
                    ""type"": ""Button"",
                    ""id"": ""10102e25-7d6d-4c46-b90b-ee3d3f39bfd5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""e7b0cf2f-9c52-4414-9556-5f29410656ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2a6c2f08-3d73-4f9d-86fe-c1362bd869f9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd520b03-d266-4993-b22c-32c27f315bb9"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb5a3244-8280-41a4-ac0a-d3c31efa8b4a"",
                    ""path"": ""<Keyboard>/delete"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""123c3669-c904-47bd-bcf4-e3de4cd23670"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Inventory UI navigation
        m_InventoryUInavigation = asset.FindActionMap("Inventory UI navigation", throwIfNotFound: true);
        m_InventoryUInavigation_Equip = m_InventoryUInavigation.FindAction("Equip", throwIfNotFound: true);
        m_InventoryUInavigation_Drop = m_InventoryUInavigation.FindAction("Drop", throwIfNotFound: true);
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

    // Inventory UI navigation
    private readonly InputActionMap m_InventoryUInavigation;
    private IInventoryUInavigationActions m_InventoryUInavigationActionsCallbackInterface;
    private readonly InputAction m_InventoryUInavigation_Equip;
    private readonly InputAction m_InventoryUInavigation_Drop;
    public struct InventoryUInavigationActions
    {
        private @InputInventoryUI m_Wrapper;
        public InventoryUInavigationActions(@InputInventoryUI wrapper) { m_Wrapper = wrapper; }
        public InputAction @Equip => m_Wrapper.m_InventoryUInavigation_Equip;
        public InputAction @Drop => m_Wrapper.m_InventoryUInavigation_Drop;
        public InputActionMap Get() { return m_Wrapper.m_InventoryUInavigation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryUInavigationActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryUInavigationActions instance)
        {
            if (m_Wrapper.m_InventoryUInavigationActionsCallbackInterface != null)
            {
                @Equip.started -= m_Wrapper.m_InventoryUInavigationActionsCallbackInterface.OnEquip;
                @Equip.performed -= m_Wrapper.m_InventoryUInavigationActionsCallbackInterface.OnEquip;
                @Equip.canceled -= m_Wrapper.m_InventoryUInavigationActionsCallbackInterface.OnEquip;
                @Drop.started -= m_Wrapper.m_InventoryUInavigationActionsCallbackInterface.OnDrop;
                @Drop.performed -= m_Wrapper.m_InventoryUInavigationActionsCallbackInterface.OnDrop;
                @Drop.canceled -= m_Wrapper.m_InventoryUInavigationActionsCallbackInterface.OnDrop;
            }
            m_Wrapper.m_InventoryUInavigationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Equip.started += instance.OnEquip;
                @Equip.performed += instance.OnEquip;
                @Equip.canceled += instance.OnEquip;
                @Drop.started += instance.OnDrop;
                @Drop.performed += instance.OnDrop;
                @Drop.canceled += instance.OnDrop;
            }
        }
    }
    public InventoryUInavigationActions @InventoryUInavigation => new InventoryUInavigationActions(this);
    public interface IInventoryUInavigationActions
    {
        void OnEquip(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
    }
}
