using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Player : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float maxHealth;

    [SerializeField] private Health_Bar healthBar;


    void Start()
    {
        health = maxHealth;
        healthBar.InitialHealthBar(maxHealth);
    }
    public void Heal(float healing)
    {
        if ((health + healing) > maxHealth)
        {
            health = maxHealth;
        }
        else
        {
            health += healing;
        }
        healthBar.ChangeCurHealth(health);

    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.ChangeCurHealth(health);
        
        if (health <= 0)
        {
            Die();
            Destroy(gameObject);
        }
    }


    void Die()
    {
        Debug.Log("Player Died");
    }

}