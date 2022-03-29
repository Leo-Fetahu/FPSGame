using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterH : MonoBehaviour
{
    public float health = 100f;
    public GameObject DeathUI;
    public GameObject HealthUI;
    public GameObject Player;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
        if (health <= 0f)
        {
            health = 0f;
        }
    }

    public void Die()
    {
        DeathUI.SetActive(true);
        HealthUI.SetActive(false);
        Player.SetActive(false);
    }
}
