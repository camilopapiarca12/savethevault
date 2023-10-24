using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{

    public int startingHealth = 1000;

    int currentHealth;

    bool isAlive = true;

    void Awake()
    {
        currentHealth = startingHealth;
    }

    public void ReceiveDamage(int damage)
    {
        if (!isAlive) return;
        currentHealth -= damage;

        Debug.Log($"Recibi daño dmg:{damage} - current:{currentHealth}");
        if(currentHealth <= 0) 
        {
            isAlive = false;
            Debug.Log("Se murio");
        //se murio hace algo
        }
    }
}
