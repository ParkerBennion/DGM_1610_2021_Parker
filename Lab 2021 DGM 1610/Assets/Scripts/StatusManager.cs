using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatusManager : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    //private Vector3 playerLocation;

    public Health healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.MaxHealth(maxHealth);
    }

    private void Update()
    {
        Vector3 here = transform.position;
        if (currentHealth < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("bulletE"))
        {
            Damager(1);
        }
    }

    public void Damager(int damage)
    {
        currentHealth -= damage;
        healthBar.MakeHealth(currentHealth);
    }
}
