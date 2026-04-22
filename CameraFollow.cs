using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 5, -7);
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + player.TransformDirection(offset);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        transform.position = smoothedPosition;
        transform.LookAt(player);
    }
}
