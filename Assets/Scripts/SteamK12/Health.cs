using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class Health : MonoBehaviour
    {
        [SerializeField] int health = 3;
        [SerializeField] GameObject deathPrefab;

        public void TakeDamage(int damage)
        {
            health -= damage;

            if (health <= 0)
            {
                Instantiate(deathPrefab, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}
