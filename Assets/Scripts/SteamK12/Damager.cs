using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class Damager : MonoBehaviour
    {
        [SerializeField] int damageAmount = 1;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Health health = collision.GetComponent<Health>();
                if (health != null)
                {
                    health.TakeDamage(damageAmount);
                }
            } 
        }
    }
}
