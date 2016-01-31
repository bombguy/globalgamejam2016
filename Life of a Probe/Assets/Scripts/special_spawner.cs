using UnityEngine;
using System.Collections;

public class special_spawner : MonoBehaviour {
	public float special_spawn_rate;
	public float special_spawn_time;
	public GameObject special_orb;

	// Use this for initialization
	void Start () {
		special_spawn_time = 15;
	}
	
	// Update is called once per frame
	void Update () {
		special_spawn_time += Time.deltaTime;

		if (special_spawn_time >= special_spawn_rate) {
			spawn_special_orb ();
			special_spawn_time = 0;
		}
	}

	void spawn_special_orb() {
		float x_coord = Random.Range (-6f, 6f);
		float y_coord = Random.Range (-6f, 6f);
		Instantiate (special_orb, new Vector3(x_coord,y_coord,0), Quaternion.identity);
	}
}
