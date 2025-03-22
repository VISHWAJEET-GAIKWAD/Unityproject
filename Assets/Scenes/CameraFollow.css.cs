using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; 
    public Vector3 offset = new Vector3(0f, 5f, -10f); 
    public float smoothTime = 0.1f; 
    private Vector3 velocity = Vector3.zero; 

    void LateUpdate()
    {
        if (player == null)
        {
            Debug.LogError("Player not assigned to CameraFollow script!");
            return;
        }

       
        Vector3 desiredPosition = player.position + offset;

        
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
        transform.position = smoothedPosition;

       
        transform.LookAt(player);
    }
}