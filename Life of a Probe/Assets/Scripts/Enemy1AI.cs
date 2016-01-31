using UnityEngine;
using System.Collections;

public class Enemy1AI : MonoBehaviour {
	public GameObject player;
	public float speed=0.05F;
	public Vector2 directionOfPlayer;
	public bool active = false;

    public SpriteRenderer[] flames;

	// Use this for initialization
	void Start () {
        //flames = GetComponents<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update () {
        flames = GetComponents<SpriteRenderer>();
        if (active)
        {
            directionOfPlayer = player.transform.position - transform.position;
            directionOfPlayer = directionOfPlayer.normalized;
            transform.Translate(directionOfPlayer * speed, Space.World);

        }
        else
        {
            Debug.Log("I should deactivate flames!");
            for (int x = 0; x < 4; x++)
                flames[x].enabled = false;
        }
	}
}