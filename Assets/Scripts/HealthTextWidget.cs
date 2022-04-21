using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextWidget : MonoBehaviour
{
    public Text healthText;



    public void UpdateHealth(float health)
    {
        healthText.text = health.ToString();
    }
}
