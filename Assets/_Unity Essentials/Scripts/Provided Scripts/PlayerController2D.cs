using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float speed = 5f; 
    public bool canMoveDiagonally = true; 

    private Rigidbody2D rb;
    private Vector2 movement; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        if (canMoveDiagonally)
        {

            movement = new Vector2(horizontalInput, verticalInput);
            RotatePlayer(horizontalInput, verticalInput);
        }
        else
        {
            // Determine the priority of movement based on input
            if (horizontalInput != 0)
            {
                movement = new Vector2(horizontalInput, 0);
                RotatePlayer(horizontalInput, 0);
            }
            else if (verticalInput != 0)
            {
                movement = new Vector2(0, verticalInput);
                RotatePlayer(0, verticalInput);
            }
            else
            {
                // Stop movement when no input is detected
                movement = Vector2.zero;
            }
        }
    }

    void FixedUpdate()
    {
        // Apply movement to the player in FixedUpdate for physics consistency
        rb.linearVelocity = movement * speed;
    }

    void RotatePlayer(float x, float y)
    {
        // If there is no input, do not rotate the player
        if (x == 0 && y == 0) return;

        // Calculate the rotation angle based on input direction
        float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
        // Apply the rotation to the player
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
