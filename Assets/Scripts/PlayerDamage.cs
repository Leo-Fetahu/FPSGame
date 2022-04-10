using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit collision)
    {
        if (collision.collider.gameObject.tag.Equals("Enemy"))
        {
            Debug.Log("Player Hit");
            CharacterH characterH = GetComponent<CharacterH>();
            
            characterH.TakeDamage(0.5f); 
        }
    }
}