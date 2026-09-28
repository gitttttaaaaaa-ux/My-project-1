using UnityEngine;

public class SegmentDestroyer : MonoBehaviour
{
    public float destroyDistance = 30f;
    private Transform player;

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");

        if (playerObj != null)
        {
            player = playerObj.transform;
        }
        else
        {
            Debug.LogError("Player tidak ditemukan! Pastikan Tag Player sudah diset ke 'Player'.");
        }
    }

    void Update()
    {
        if (player != null && player.position.x - transform.position.x > destroyDistance)
        {
            Destroy(gameObject);
        }
    }
}