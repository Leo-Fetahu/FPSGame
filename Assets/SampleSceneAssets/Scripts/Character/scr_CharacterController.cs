using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_CharacterController : MonoBehaviour
{
    private Defaultinput defaultInput;
    public Vector2 input_Movement;
    public Vector2 input_View;

    private void Awake()
    {
        defaultInput = new Defaultinput();

        defaultInput.Character.Movement.performed += e => input_Movement = e.ReadValue<Vector2>();
        defaultInput.Character.View.performed += e => input_View = e.ReadValue<Vector2>();

        defaultInput.Enable();
    }

    private void Update()
    {
        CalculateView();
        CalculateMovement();
    }

    private void CalculateView()
    {

    }

    private void CalculateMovement()
    {

    }
}
