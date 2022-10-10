using UnityEngine;

namespace SpaceShooter.Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private EnemyManager enemyPrefab;
        [SerializeField] private float timeBtwSpawns;

        private Vector2 screenBounds;
        private float spawnPointX;
        private float spawnPointY;
        private float timer;
        private Vector3 spawnPoint;

        private void Start()
        {
            screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
            spawnPointX = transform.position.x;
            timer = timeBtwSpawns;
        }

        private void Update()
        {
            if (timer < Time.time)
            {
                SpawnEnemy();
                timer = Time.time + timeBtwSpawns;
            }
        }

        private void SpawnEnemy()
        {
            spawnPointY = Random.Range(-screenBounds.y, screenBounds.y);
            spawnPoint = new Vector3(spawnPointX, spawnPointY, transform.position.z);
            Instantiate(enemyPrefab, spawnPoint, Quaternion.Euler(Vector3.zero));
        }
    }
}
