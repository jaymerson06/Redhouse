using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player's movement

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Capture input from both WASD and arrow keys
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right keys
        movement.y = Input.GetAxisRaw("Vertical");   // W/S or Up/Down keys
    }

    void FixedUpdate()
    {
        // Apply movement to the Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}