using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Torre : MonoBehaviour
{
    [SerializeField] Slider healthSlider;
    [SerializeField] int sceneToLoad;
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
        healthSlider.value = Mathf.Max(currentHealth, 0);
        Debug.Log($"Recibi daño dmg:{damage} - current:{currentHealth}");
        if(currentHealth <= 0) 
        {
            isAlive = false;
            Debug.Log("Se murio");
            //se murio hace algo
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
