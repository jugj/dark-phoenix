using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private static float speed = 1f;
    private final List<GameObject> list = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Quad);
            list.Add(obj);
            Renderer renderer = obj.GetComponent<Renderer>();
            renderer.material.mainTexture = texture;
            obj.transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) transform.Translate(Vector3.left * speed);
        if (Input.GetKeyDown(KeyCode.RightArrow)) transform.Translate(Vector3.right * speed);
        if (Input.GetKeyDown(KeyCode.UpArrow)) transform.Translate(Vector3.up * speed);
        if (Input.GetKeyDown(KeyCode.DownArrow)) transform.Translate(Vector3.down * speed);
    }
}
