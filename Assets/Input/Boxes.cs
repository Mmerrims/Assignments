//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Input/Boxes.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Boxes: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Boxes()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Boxes"",
    ""maps"": [
        {
            ""name"": ""BoxMap"",
            ""id"": ""6122d39b-e746-47b2-aa44-1a4cd8eeb89b"",
            ""actions"": [
                {
                    ""name"": ""SpawnBox"",
                    ""type"": ""Button"",
                    ""id"": ""1d911c45-bf87-46b1-98a2-9350757c94aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DestroyGameObjects"",
                    ""type"": ""Button"",
                    ""id"": ""e54cff12-b3e4-4d73-b435-2f53172bc571"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e61b0737-52ae-487b-829c-0b5e1f265d7b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnBox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a03ff1e0-5af5-4f34-a439-dc6bef2063cf"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DestroyGameObjects"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BoxMap
        m_BoxMap = asset.FindActionMap("BoxMap", throwIfNotFound: true);
        m_BoxMap_SpawnBox = m_BoxMap.FindAction("SpawnBox", throwIfNotFound: true);
        m_BoxMap_DestroyGameObjects = m_BoxMap.FindAction("DestroyGameObjects", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // BoxMap
    private readonly InputActionMap m_BoxMap;
    private List<IBoxMapActions> m_BoxMapActionsCallbackInterfaces = new List<IBoxMapActions>();
    private readonly InputAction m_BoxMap_SpawnBox;
    private readonly InputAction m_BoxMap_DestroyGameObjects;
    public struct BoxMapActions
    {
        private @Boxes m_Wrapper;
        public BoxMapActions(@Boxes wrapper) { m_Wrapper = wrapper; }
        public InputAction @SpawnBox => m_Wrapper.m_BoxMap_SpawnBox;
        public InputAction @DestroyGameObjects => m_Wrapper.m_BoxMap_DestroyGameObjects;
        public InputActionMap Get() { return m_Wrapper.m_BoxMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BoxMapActions set) { return set.Get(); }
        public void AddCallbacks(IBoxMapActions instance)
        {
            if (instance == null || m_Wrapper.m_BoxMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BoxMapActionsCallbackInterfaces.Add(instance);
            @SpawnBox.started += instance.OnSpawnBox;
            @SpawnBox.performed += instance.OnSpawnBox;
            @SpawnBox.canceled += instance.OnSpawnBox;
            @DestroyGameObjects.started += instance.OnDestroyGameObjects;
            @DestroyGameObjects.performed += instance.OnDestroyGameObjects;
            @DestroyGameObjects.canceled += instance.OnDestroyGameObjects;
        }

        private void UnregisterCallbacks(IBoxMapActions instance)
        {
            @SpawnBox.started -= instance.OnSpawnBox;
            @SpawnBox.performed -= instance.OnSpawnBox;
            @SpawnBox.canceled -= instance.OnSpawnBox;
            @DestroyGameObjects.started -= instance.OnDestroyGameObjects;
            @DestroyGameObjects.performed -= instance.OnDestroyGameObjects;
            @DestroyGameObjects.canceled -= instance.OnDestroyGameObjects;
        }

        public void RemoveCallbacks(IBoxMapActions instance)
        {
            if (m_Wrapper.m_BoxMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBoxMapActions instance)
        {
            foreach (var item in m_Wrapper.m_BoxMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BoxMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BoxMapActions @BoxMap => new BoxMapActions(this);
    public interface IBoxMapActions
    {
        void OnSpawnBox(InputAction.CallbackContext context);
        void OnDestroyGameObjects(InputAction.CallbackContext context);
    }
}
