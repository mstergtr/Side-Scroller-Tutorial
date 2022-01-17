using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class PlayerBullet : MonoBehaviour
    {
        [SerializeField] float speed = 2.0f;
        [SerializeField] int damage = 1;

        void Update()
        {
            Vector3 bulletPos = transform.position;

            bulletPos = new Vector3(bulletPos.x + speed * Time.deltaTime, bulletPos.y, 0.0f);

            transform.position = bulletPos;

            if (bulletPos.x >= 4)
            {
                Destroy(gameObject);
            }
        }

        void OnTriggerEnter2D(Collider2D other) 
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);
        }

    }
}
