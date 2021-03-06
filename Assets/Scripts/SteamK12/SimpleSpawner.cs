using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class SimpleSpawner : MonoBehaviour
    {
        [SerializeField] GameObject enemy;
        [SerializeField] Transform[] spawnPoints;
        [SerializeField] bool isSpawning = true;
        [SerializeField] float timeBetweenSpawns = 2f;
        [SerializeField] float spawnTime = 1f;

        void Start()
        {
            if (spawnPoints.Length == 0)
            {
                Debug.Log("no spawn points referenced");
            }
            InvokeRepeating(nameof(SpawnEnemy), spawnTime, timeBetweenSpawns);
        }

        void SpawnEnemy()
        {
            if (!isSpawning) return;

            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
