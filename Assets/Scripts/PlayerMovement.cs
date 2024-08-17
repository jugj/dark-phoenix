using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private static float speed = 1f;
    private List<GameObject> list = new List<GameObject>();
    public Texture2D texture;
    public Rigidbody2D rb; //establishes a variable for this code, "rb" for "RigidBody"

    // Start is called before the first frame update
    void Start()
    {
        //rb = gameObject.GetComponent<Rigidbody2D>();
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
        Vector3 current = transform.position;

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) transform.Translate(Vector3.left * speed);
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) transform.position += (Vector3.right * speed);
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) transform.position += (Vector3.up * speed);
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) transform.position += (Vector3.down * speed);

        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        foreach (GameObject go in allObjects)
            if (go.activeInHierarchy)
                if (false && go.transform.position != transform.position && Vector3.Distance(go.transform.position, transform.position) < 1) transform.position = current;
    }
}
