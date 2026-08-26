using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right
        float v = Input.GetAxisRaw("Vertical");   // W/S or Up/Down

        Vector3 move = new Vector3(h, 0f, v).normalized;
        transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);
    }
}