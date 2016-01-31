using UnityEngine;
using System.Collections;

public class Enemy1AI : MonoBehaviour {

    Transform t;
    Vector3 dir;
    float speed; 
	// Use this for initialization
	void Start () {
        t = GetComponent<Transform>();
        if ((int)(Random.value * 10) % 2 == 0)
            dir = Vector3.up;
        else
            dir = Vector3.right;
        //flames = GetComponents<SpriteRenderer>();
        speed = 3f;
	}

	// Update is called once per frame
	void Update () {
        t.position += dir * speed * Time.deltaTime;
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        speed *= -1;
    }
}