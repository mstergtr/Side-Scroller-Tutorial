using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] int health = 2;
        [SerializeField] int score = 10;
        [SerializeField] GameObject deathPrefab;
        
        public void TakeDamage (int damage)
        {
            health -= damage;

            if (health <= 0)
            {
                Instantiate(deathPrefab, transform.position, transform.rotation);
                ScoreManager.Instance.IncreseScore(score);
                Destroy(gameObject);
            }
        }
    }
}
