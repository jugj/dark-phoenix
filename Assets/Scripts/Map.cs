using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public Texture2D texture;
    List<GameObject> list = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Random.Range(0, 10) == 0)
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Quad);
            list.Add(obj);
            Renderer renderer = obj.GetComponent<Renderer>();
            renderer.material.mainTexture = texture;
            obj.transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0);
        }
        list.ForEach(delegate (GameObject obj)
        {
            obj.transform.position = obj.transform.position + new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 0);
        });

    }
}
