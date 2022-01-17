using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class EnemyBehavior : MonoBehaviour
    {
        [SerializeField] float speed = 3f;
        void Update()
        {
            Vector3 enemyPos = transform.position;

            enemyPos = new Vector3(enemyPos.x - speed * Time.deltaTime, enemyPos.y, 0.0f);

            transform.position = enemyPos;

            if (enemyPos.x <= -4)
            {
                Destroy(gameObject);
            }
        }
    }
}
