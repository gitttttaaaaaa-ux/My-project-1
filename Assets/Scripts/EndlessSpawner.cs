using UnityEngine;

public class EndlessSpawner : MonoBehaviour
{
    public Transform player;
    public GameObject segmentPrefab;
    public Transform firstSegment;

    public float spawnAheadDistance = 20f;
    public float segmentWidth = 18f;

    private float nextSpawnX;
    private float spawnY;
    private float spawnZ;

    void Start()
    {
        if (player == null || segmentPrefab == null || firstSegment == null)
        {
            Debug.LogError("Player, Segment Prefab, atau First Segment belum diisi!");
            enabled = false;
            return;
        }

        if (segmentWidth <= 0.1f)
        {
            Debug.LogError("Segment Width tidak valid!");
            enabled = false;
            return;
        }

        spawnY = firstSegment.position.y;
        spawnZ = firstSegment.position.z;

        nextSpawnX = firstSegment.position.x + segmentWidth;
    }

    void Update()
    {
        if (nextSpawnX < player.position.x + spawnAheadDistance)
        {
            Instantiate(
                segmentPrefab,
                new Vector3(nextSpawnX, spawnY, spawnZ),
                Quaternion.identity
            );

            nextSpawnX += segmentWidth;
        }
    }
}