// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Defaultinput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Defaultinput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Defaultinput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Defaultinput"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""d06e2aac-ff99-44cc-a642-5e24f678f473"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e6ee8640-8242-41cb-8f98-8d2e67e0cecd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1700fe6a-f840-43cd-8c45-b9e98c290459"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fae3f360-4fd3-4e51-9949-20bfa810710a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""f893ed41-7209-4634-b236-411505573a8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Prone"",
                    ""type"": ""PassThrough"",
                    ""id"": ""eacd4793-ef82-4ecf-bea5-7443799e3161"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""3f304d36-228e-4746-990c-a987b3066224"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SprintReleased"",
                    ""type"": ""Button"",
                    ""id"": ""a3d95fac-c084-432d-b0e7-b383c80fcf24"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5e42c1d2-923d-4152-86bf-1485f35784af"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""4a51380c-7c35-45fe-84c7-e93eb7712c7f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7dfd3c55-5dc4-4d75-812a-f87540ad1b5e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b9e13836-4e4c-4c67-9870-a6cef8a6312d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8a98c950-feb0-41b3-b86d-d39139cb93f0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""63fda28d-00e5-4f1d-a264-8e4ea7133a8a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""27434ab7-225c-44a0-85e0-eb8fccb16ec5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01f44c58-ceb1-4c3d-8e01-188481db1536"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73681631-e8cd-48a8-be63-888ded0d2690"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7762c5d-1929-4b6c-99fc-2b1608c965f1"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea5e5537-30de-4a6f-b9a3-a50203559977"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a6f4707-e8bd-4c57-9f87-cf07d13bc42b"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Weapon"",
            ""id"": ""db735c04-ebf5-42da-8c68-a6c838f845f5"",
            ""actions"": [
                {
                    ""name"": ""Fire2Pressed"",
                    ""type"": ""Button"",
                    ""id"": ""4ae09776-e508-47de-94c0-37df3dc445dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire2Released"",
                    ""type"": ""Button"",
                    ""id"": ""ff2b353a-e59e-45bc-9b4f-c0a3718f89d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fa63d1bf-aa15-4655-b2c4-a626645f6e08"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2Pressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d19b5f6c-d6d3-4048-b422-60d80c7b6f90"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2Released"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
        m_Character_View = m_Character.FindAction("View", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
        m_Character_Crouch = m_Character.FindAction("Crouch", throwIfNotFound: true);
        m_Character_Prone = m_Character.FindAction("Prone", throwIfNotFound: true);
        m_Character_Sprint = m_Character.FindAction("Sprint", throwIfNotFound: true);
        m_Character_SprintReleased = m_Character.FindAction("SprintReleased", throwIfNotFound: true);
        // Weapon
        m_Weapon = asset.FindActionMap("Weapon", throwIfNotFound: true);
        m_Weapon_Fire2Pressed = m_Weapon.FindAction("Fire2Pressed", throwIfNotFound: true);
        m_Weapon_Fire2Released = m_Weapon.FindAction("Fire2Released", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Movement;
    private readonly InputAction m_Character_View;
    private readonly InputAction m_Character_Jump;
    private readonly InputAction m_Character_Crouch;
    private readonly InputAction m_Character_Prone;
    private readonly InputAction m_Character_Sprint;
    private readonly InputAction m_Character_SprintReleased;
    public struct CharacterActions
    {
        private @Defaultinput m_Wrapper;
        public CharacterActions(@Defaultinput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Character_Movement;
        public InputAction @View => m_Wrapper.m_Character_View;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputAction @Crouch => m_Wrapper.m_Character_Crouch;
        public InputAction @Prone => m_Wrapper.m_Character_Prone;
        public InputAction @Sprint => m_Wrapper.m_Character_Sprint;
        public InputAction @SprintReleased => m_Wrapper.m_Character_SprintReleased;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @View.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @View.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @View.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @Jump.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnCrouch;
                @Prone.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnProne;
                @Prone.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnProne;
                @Prone.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnProne;
                @Sprint.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @SprintReleased.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprintReleased;
                @SprintReleased.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprintReleased;
                @SprintReleased.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprintReleased;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @View.started += instance.OnView;
                @View.performed += instance.OnView;
                @View.canceled += instance.OnView;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Prone.started += instance.OnProne;
                @Prone.performed += instance.OnProne;
                @Prone.canceled += instance.OnProne;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @SprintReleased.started += instance.OnSprintReleased;
                @SprintReleased.performed += instance.OnSprintReleased;
                @SprintReleased.canceled += instance.OnSprintReleased;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // Weapon
    private readonly InputActionMap m_Weapon;
    private IWeaponActions m_WeaponActionsCallbackInterface;
    private readonly InputAction m_Weapon_Fire2Pressed;
    private readonly InputAction m_Weapon_Fire2Released;
    public struct WeaponActions
    {
        private @Defaultinput m_Wrapper;
        public WeaponActions(@Defaultinput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire2Pressed => m_Wrapper.m_Weapon_Fire2Pressed;
        public InputAction @Fire2Released => m_Wrapper.m_Weapon_Fire2Released;
        public InputActionMap Get() { return m_Wrapper.m_Weapon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponActions set) { return set.Get(); }
        public void SetCallbacks(IWeaponActions instance)
        {
            if (m_Wrapper.m_WeaponActionsCallbackInterface != null)
            {
                @Fire2Pressed.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Pressed;
                @Fire2Pressed.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Pressed;
                @Fire2Pressed.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Pressed;
                @Fire2Released.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Released;
                @Fire2Released.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Released;
                @Fire2Released.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Released;
            }
            m_Wrapper.m_WeaponActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire2Pressed.started += instance.OnFire2Pressed;
                @Fire2Pressed.performed += instance.OnFire2Pressed;
                @Fire2Pressed.canceled += instance.OnFire2Pressed;
                @Fire2Released.started += instance.OnFire2Released;
                @Fire2Released.performed += instance.OnFire2Released;
                @Fire2Released.canceled += instance.OnFire2Released;
            }
        }
    }
    public WeaponActions @Weapon => new WeaponActions(this);
    public interface ICharacterActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnView(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnProne(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSprintReleased(InputAction.CallbackContext context);
    }
    public interface IWeaponActions
    {
        void OnFire2Pressed(InputAction.CallbackContext context);
        void OnFire2Released(InputAction.CallbackContext context);
    }
}
