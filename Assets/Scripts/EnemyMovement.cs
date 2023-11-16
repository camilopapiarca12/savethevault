using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;
    private int pathIndex = 0;
    private float da�oEnemy = 10;
    private float vidaTotal = 100;
    public GameObject Finish;

    private void Start()
    {
        target = LevelManager.main.path[pathIndex];
    }
    private void Update()
    {
        if (Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            pathIndex++;


            if (pathIndex  == LevelManager.main.path.Length) { 
                EnemySpawner.onEnemyDestroy.Invoke();
                Destroy(gameObject);
                vidaTotal = vidaTotal - da�oEnemy;

                if(vidaTotal <= 0) 
                {
                    Finish.SetActive(true);
                }
                return;
            }
            else
            {
                target = LevelManager.main.path[pathIndex];
            }
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;

        rb.velocity = direction * moveSpeed;
    }

}
