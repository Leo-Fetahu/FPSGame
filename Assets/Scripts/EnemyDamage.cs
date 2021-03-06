using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    killCounter killCounterScript;

    public int enemyHP = 100;
    public GameObject projectile;
    public Transform projectilePoint;

    private void Start()
    {
        killCounterScript = GameObject.Find("KCO").GetComponent<killCounter>();
    }

    public void Attack()
    {
        Rigidbody rb = Instantiate(projectile, projectilePoint.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 30f, ForceMode.Impulse);
        rb.AddForce(transform.up * 7, ForceMode.Impulse);
    }

    public Animator animator;
    public void TakeDamage(int damageAmount)
    {
        enemyHP -= damageAmount;
        if (enemyHP <= 0)
        {
            animator.SetTrigger("Death");
            killCounterScript.AddKill();
            GetComponent<CapsuleCollider>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            
        } 
        else
        {
            animator.SetTrigger("Damage");
            
        }

    }
}
