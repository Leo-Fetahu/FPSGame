using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterH : MonoBehaviour
{
    public float maxHealth = 100f;
    public GameObject DeathUI;
    public GameObject HealthUI;
    public GameObject Player;

    public void TakeDamage(float amount)
    {
        maxHealth -= amount;
        if (maxHealth <= 0f)
        {
            Die();
        }
        if (maxHealth <= 0f)
        {
            maxHealth = 0f;
        }
    }

    public void Die()
    {
        DeathUI.SetActive(true);
        HealthUI.SetActive(false);
        Player.SetActive(false);
    }
}
