using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SteamK12.SpaceShooter
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] int health = 2;
        [SerializeField] int score = 10;
        public GameObject deathPrefab;
        public void TakeDamage (int damage)
        {
            health -= damage;

            if (health <= 0)
            {
                Instantiate(deathPrefab, transform.position, transform.rotation);
                ScoreManager.instance.IncreseScore(score);
                Destroy(gameObject);
            }
        }
    }
}
