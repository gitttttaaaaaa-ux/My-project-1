using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    public float destroyDistance = 20f;

    private Transform player;

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");

        if (playerObj != null)
        {
            player = playerObj.transform;
        }
    }

    void Update()
    {
        if (player != null &&
            player.position.x - transform.position.x > destroyDistance)
        {
            Destroy(gameObject);
        }
    }
}
