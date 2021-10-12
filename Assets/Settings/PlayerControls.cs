// GENERATED AUTOMATICALLY FROM 'Assets/Settings/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay map"",
            ""id"": ""213f9aa5-54a2-4f72-8d66-4cc03e185565"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ad40b67c-8cf8-4e34-8d74-250efc94e560"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slide"",
                    ""type"": ""Button"",
                    ""id"": ""9fd58f78-3231-446c-9a7e-3257a6b4490e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3dd5a8fe-5680-4a7c-af5c-20d117f03bfc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tag"",
                    ""type"": ""Button"",
                    ""id"": ""422f3004-b9e9-44d4-bdce-7be25932ad44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""66afcf9d-e0cd-4f33-9e5d-47e5c446c5d2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5cb6368-8b92-4f96-a664-75474571caa1"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a8e5615-3f4f-4a9e-88e9-9b99e786d3fa"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44c174fe-1f4e-4ad5-ba32-aa3671cf6343"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay map
        m_Gameplaymap = asset.FindActionMap("Gameplay map", throwIfNotFound: true);
        m_Gameplaymap_Jump = m_Gameplaymap.FindAction("Jump", throwIfNotFound: true);
        m_Gameplaymap_Slide = m_Gameplaymap.FindAction("Slide", throwIfNotFound: true);
        m_Gameplaymap_Move = m_Gameplaymap.FindAction("Move", throwIfNotFound: true);
        m_Gameplaymap_Tag = m_Gameplaymap.FindAction("Tag", throwIfNotFound: true);
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

    // Gameplay map
    private readonly InputActionMap m_Gameplaymap;
    private IGameplaymapActions m_GameplaymapActionsCallbackInterface;
    private readonly InputAction m_Gameplaymap_Jump;
    private readonly InputAction m_Gameplaymap_Slide;
    private readonly InputAction m_Gameplaymap_Move;
    private readonly InputAction m_Gameplaymap_Tag;
    public struct GameplaymapActions
    {
        private @PlayerControls m_Wrapper;
        public GameplaymapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Gameplaymap_Jump;
        public InputAction @Slide => m_Wrapper.m_Gameplaymap_Slide;
        public InputAction @Move => m_Wrapper.m_Gameplaymap_Move;
        public InputAction @Tag => m_Wrapper.m_Gameplaymap_Tag;
        public InputActionMap Get() { return m_Wrapper.m_Gameplaymap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplaymapActions set) { return set.Get(); }
        public void SetCallbacks(IGameplaymapActions instance)
        {
            if (m_Wrapper.m_GameplaymapActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnJump;
                @Slide.started -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnSlide;
                @Slide.performed -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnSlide;
                @Slide.canceled -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnSlide;
                @Move.started -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnMove;
                @Tag.started -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnTag;
                @Tag.performed -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnTag;
                @Tag.canceled -= m_Wrapper.m_GameplaymapActionsCallbackInterface.OnTag;
            }
            m_Wrapper.m_GameplaymapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Slide.started += instance.OnSlide;
                @Slide.performed += instance.OnSlide;
                @Slide.canceled += instance.OnSlide;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Tag.started += instance.OnTag;
                @Tag.performed += instance.OnTag;
                @Tag.canceled += instance.OnTag;
            }
        }
    }
    public GameplaymapActions @Gameplaymap => new GameplaymapActions(this);
    public interface IGameplaymapActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnSlide(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnTag(InputAction.CallbackContext context);
    }
}
