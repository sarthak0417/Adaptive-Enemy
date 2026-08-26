using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // drag Player here in Inspector
    public Vector3 offset = new Vector3(0f, 8f, -6f);

    void LateUpdate()
    {
        if (target == null) return;
        transform.position = target.position + offset;
        transform.LookAt(target.position);
    }
}