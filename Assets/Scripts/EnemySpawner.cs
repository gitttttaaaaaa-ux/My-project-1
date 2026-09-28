using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform player;
    public GameObject enemyPrefab;

    public float spawnAheadDistance = 15f;
    public float minSpawnGap = 8f;
    public float maxSpawnGap = 15f;
    public float spawnY = -1f;

    private float nextSpawnX;

    void Start()
    {
        nextSpawnX = player.position.x + spawnAheadDistance;
    }

    void Update()
    {
        if (player.position.x + spawnAheadDistance >= nextSpawnX)
        {
            SpawnEnemy();

            nextSpawnX += Random.Range(minSpawnGap, maxSpawnGap);
        }
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(
            nextSpawnX,
            spawnY,
            0f
        );

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}