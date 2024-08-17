using UnityEngine;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public float moveForce = 10f;
    public float maxSpeed = 5f;
    public float stopForce = 15f;
    private List<GameObject> list = new List<GameObject>();
    public Texture2D texture;
    public Rigidbody2D rb;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    void FixedUpdate()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            movement += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            movement += Vector2.right;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            movement += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            movement += Vector2.down;
        }

        if (movement != Vector2.zero)
        {
            // Bewegung
            rb.AddForce(movement.normalized * moveForce);

            // Geschwindigkeit begrenzen
            rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
        }
        else
        {
            // Abruptes Stoppen
            Vector2 oppositeForce = -rb.velocity * stopForce;
            rb.AddForce(oppositeForce);
        }
    }
}