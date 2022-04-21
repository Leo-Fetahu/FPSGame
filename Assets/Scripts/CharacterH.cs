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

    public HealthTextWidget healthText;

    public int health;

    public int Health
    {
        get => health;
        set
        {
            health = value;

            if (maxHealth < 0)
            {
                return;
            }

            if (healthText != null)
            {
                healthText.UpdateHealth(maxHealth);
            }
        }
    }

    private void Awake()
    {
        maxHealth = health;

        if (healthText != null)
        {
            healthText.UpdateHealth(maxHealth);
        }
    }

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
        Destroy(gameObject);
        DeathUI.SetActive(true);
        HealthUI.SetActive(false);
        Player.SetActive(false);
    }
}
