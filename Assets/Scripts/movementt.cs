using UnityEngine;

public class TopDownPlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        // Bewegungseingaben erfassen
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Bewegungsrichtung berechnen
        Vector3 moveDirection = new Vector3(moveX, moveY, 0).normalized;

        // Spieler bewegen
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}