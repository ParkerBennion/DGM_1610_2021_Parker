using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusManager : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    public Health healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.MaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Damager(1);
        }
    }

    void Damager(int damage)
    {
        currentHealth -= damage;
        healthBar.MakeHealth(currentHealth);
    }
}
