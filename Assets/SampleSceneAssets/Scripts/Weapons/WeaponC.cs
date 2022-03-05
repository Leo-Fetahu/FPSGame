using UnityEngine;
using static scr_Models;

public class WeaponC : MonoBehaviour
{
    private CharacterC characterController;

    [Header("Settings")]
    public WeaponSettingsModel settings;

    bool isInitialised;

    Vector3 newWeaponRotation;
    Vector3 newWeaponRotationVelocity;

    private void Start()
    {
        newWeaponRotation = transform.localRotation.eulerAngles;
    }

    public void Initialise(CharacterC CharacterController)
    {
        characterController = CharacterController;
        isInitialised = true;
    }

    private void Update()
    {
        if (!isInitialised)
        {
            return;
        }

        newWeaponRotation.y += settings.SwayAmount * (settings.SwayXInverted ? -characterController.input_View.x : characterController.input_View.x) * Time.deltaTime;
        newWeaponRotation.x += settings.SwayAmount * (settings.SwayYInverted ? characterController.input_View.y : -characterController.input_View.y) * Time.deltaTime;
        //newWeaponRotation.x = Mathf.Clamp(newWeaponRotation.x, viewClampYMin, viewClampYMax);

        transform.localRotation = Quaternion.Euler(newWeaponRotation);
    }
}
