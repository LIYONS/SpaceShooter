using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyManager enemyPrefab;
    [SerializeField] private float timeBtwSpawns;
    [SerializeField] private int maxSpawns;

    private int currentEnemies;
    private Vector2 screenBounds;
    private float spawnPointX;
    private float spawnPointY;
    private float timer;
    private Vector3 spawnPoint;
    private void Start()
    {
        currentEnemies = 0;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        spawnPointX = transform.position.x;
        timer = timeBtwSpawns;
    }

    private void Update()
    {
        if(timer<Time.time && currentEnemies<maxSpawns)
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

    private void OnEnemyDied()
    {
        currentEnemies -= 1;
    }
}
