using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag.Equals ("Player"))
        {
            CharacterH characterH = collision.collider.GetComponent<CharacterH>();

            characterH.TakeDamage(30);

            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}