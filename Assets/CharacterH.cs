using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterH : MonoBehaviour
{
    public float health = 100f;
    public GameObject DeathUI;
    public GameObject HealthUI;
    public GameObject player;
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
        player.SetActive(false);
    }
}
