using UnityEngine;
using System.Collections;

public class special_spawner : MonoBehaviour {
	public float special_spawn_rate;
	public float special_spawn_time;
	public int monster_count;
	public GameObject special_orb;
	public GameObject enemy1;
	public GameObject boss;


	// Use this for initialization
	void Start () {
		special_spawn_time = 15;
		monster_count = GameInformation.orb_count;
	}

	// Update is called once per frame
	void Update () {
		special_spawn_time += Time.deltaTime;

		if (special_spawn_time >= special_spawn_rate) {
			spawn_special_orb ();
			special_spawn_time = 0;
		}
		if (monster_count < GameInformation.orb_count) {
			spawn_enemy ();
			monster_count++;
		}
		if (GameInformation.orb_count >= GameInformation.orb_to_next_level [GameInformation.level]) {
			spawn_boss ();
			GameInformation.level++;
		}
	}

	void spawn_special_orb() {
		float x_coord = Random.Range (-6f, 6f);
		float y_coord = Random.Range (-6f, 6f);
		Instantiate (special_orb, new Vector3(x_coord,y_coord,0), Quaternion.identity);
	}

	void spawn_boss() {
		Instantiate (boss, new Vector3(0,0,0), Quaternion.identity);
	}

	void spawn_enemy() {
		float x_coord = Random.Range (-6f, 6f);
		float y_coord = Random.Range (-6f, 6f);
		Instantiate (enemy1, new Vector3(x_coord,y_coord,0), Quaternion.identity);
	}
}
