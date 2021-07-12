using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    int health = 3;
    [SerializeField]
    UnityEvent playerDeath;

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    private void Update()
    {
        if (health <= 0)
        {
            playerDeath.Invoke();
            Destroy(gameObject);
        }
    }
}
