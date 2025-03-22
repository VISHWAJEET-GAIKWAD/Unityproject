using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f; 
    public float groundSizeX = 100f; 
    public float groundSizeZ = 100f; 
    private Rigidbody rb;
    private float cubeHalfSizeX; 
    private float cubeHalfSizeZ; 
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();

        
        cubeHalfSizeX = transform.localScale.x / 2f;
        cubeHalfSizeZ = transform.localScale.z / 2f;
    }

    void Update()
    {
        
        float moveInputZ = Input.GetAxis("Vertical"); 
        float moveInputX = Input.GetAxis("Horizontal"); 

        
        Vector3 movement = new Vector3(moveInputX, 0f, moveInputZ).normalized * moveSpeed * Time.deltaTime;

        
        Vector3 newPosition = rb.position + movement;

        
        newPosition.x = Mathf.Clamp(newPosition.x, -groundSizeX / 2 + cubeHalfSizeX, groundSizeX / 2 - cubeHalfSizeX);
        newPosition.z = Mathf.Clamp(newPosition.z, -groundSizeZ / 2 + cubeHalfSizeZ, groundSizeZ / 2 - cubeHalfSizeZ);

        
        rb.MovePosition(newPosition);
    }
}