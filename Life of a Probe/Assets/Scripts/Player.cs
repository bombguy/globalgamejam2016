using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public SpriteRenderer player_image;
	public Sprite normal;
	public Sprite special;
    Rigidbody2D rg2D;
    Transform t;
    float v = 4;
    // Use this for initialization
    void Start()
    {
		player_image = this.GetComponent<SpriteRenderer> ();
		normal = Resources.Load <Sprite> ("Sprites/Main Char2");
		special = Resources.Load <Sprite> ("Sprites/Main Char Power Up");
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
		if (GameInformation.special_count == 3) {
			Debug.Log ("AHHHH! Im evolving!");
			GameInformation.power_up_duration = 10;
			GameInformation.special_count = 0;
			player_image.sprite = special;
		}
		else if (GameInformation.power_up_duration <= 0) {
			player_image.sprite = normal;
		}
    }
}
