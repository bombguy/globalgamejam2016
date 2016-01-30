using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    Rigidbody2D rg2D;
    Transform t;
    float v = 4;
    // Use this for initialization
    void Start()
    {
        rg2D = GetComponent<Rigidbody2D>();
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            t.position += Vector3.up * v * Time.deltaTime;
            //rg2D.MovePosition(new Vector2(t.position.x, t.position.y + 1) * v);
            //t.position.y += 5;
        }

        if (Input.GetKey(KeyCode.A))
        {
            t.position += Vector3.left * v * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            t.position += Vector3.down * v * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            t.position += Vector3.right * v * Time.deltaTime;
        }
    }
}
