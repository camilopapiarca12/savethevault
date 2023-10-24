using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.TopDownEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 10;
    public float timeBetweenDamage = 1;
    float timer = 0;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Torre"))
        {
            timer += Time.deltaTime;
            if (timer > timeBetweenDamage)
            {
                timer = 0;
                other.GetComponent<Torre>().ReceiveDamage(damage);
            }
        }

    }

}
