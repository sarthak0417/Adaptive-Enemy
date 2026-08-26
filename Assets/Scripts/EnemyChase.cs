using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player; // drag Player here in Inspector
    public float moveSpeed = 3.5f; // keep slightly slower than player for now

    void Update()
    {
        if (player == null) return;

        Vector3 direction = (player.position - transform.position);
        direction.y = 0f; // stay on the ground plane
        direction = direction.normalized;

        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
    }
}