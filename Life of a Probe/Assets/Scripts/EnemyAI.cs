using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	public GameObject player;
	public float speed=0.05F;
	public Vector2 directionOfPlayer;
	public bool active = true;

	// Use this for initialization
	void Start () {	

	}

	// Update is called once per frame
	void Update () {
		if (active) {
			directionOfPlayer = player.transform.position - transform.position;
			directionOfPlayer = directionOfPlayer.normalized;
			transform.Translate (directionOfPlayer * speed, Space.World);

		}
	}
}