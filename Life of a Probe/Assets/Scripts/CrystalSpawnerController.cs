using UnityEngine;
using System.Collections;

public class CrystalSpawnerController : MonoBehaviour {
	public int radius;
	public int spawn_timer;
	public float current_time;
	public GameObject orb;
	public Transform current_position;

	void Start () {
		current_time = 0;
		spawn_timer = 3;
		current_position = this.gameObject.transform;
	}

	void Update () {
		current_time+= Time.deltaTime;

		if (current_time >= spawn_timer) {
			spawn_orb ();
			current_time = 0;
		}
	}

	void spawn_orb() {
		Debug.Log ("Spawning a orb");
		Instantiate (orb, new Vector3(current_position.position.x,current_position.position.y,0), Quaternion.identity);
	}
}
