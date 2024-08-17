using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // called when the cube hits the floor
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene(3);
    }
}