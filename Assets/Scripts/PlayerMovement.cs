using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private static float speed = 1f;
    private bool colliding;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 current = transform.position;

        if (Input.GetKeyDown(KeyCode.LeftArrow)) transform.position += Vector3.left * speed;
        if (Input.GetKeyDown(KeyCode.RightArrow)) transform.position += Vector3.right * speed;
        if (Input.GetKeyDown(KeyCode.UpArrow)) transform.position += Vector3.up * speed;
        if (Input.GetKeyDown(KeyCode.DownArrow)) transform.position += Vector3.down * speed;

        if (colliding)
        {
            transform.position = current;
            colliding = false;
        }

        Debug.Log("hi");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("colliding");
        colliding = true;
    }
}
