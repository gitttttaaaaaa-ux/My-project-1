using UnityEngine;

public class AutoRun : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
    }
}