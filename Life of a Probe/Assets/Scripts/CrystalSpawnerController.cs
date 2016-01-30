using UnityEngine;
using System.Collections;

public class CrystalSpawnerController : MonoBehaviour {
	public float radius;
	public int spawn_timer;
	public float monster_spawn_rate;
	public float monster_spawn_time;
	public float current_time;
	public GameObject orb;
	public GameObject enemy;
	public Transform current_position;

	void Start () {
		current_time = 0;
		radius = 1.4f;
		spawn_timer = 5;
		monster_spawn_rate = Random.Range (10.0f, 15.0f);
		current_position = this.gameObject.transform;
	}

	void Update () {
		current_time+= Time.deltaTime;
		monster_spawn_time += Time.deltaTime;

		if (current_time >= spawn_timer) {
			spawn_orb ();
			current_time = 0;
		}

		if (monster_spawn_time >= monster_spawn_rate) {
			spawn_enemy ();
			monster_spawn_time = 0;
		}
	}

	void spawn_orb() {
		int x_direction = (int)(Random.Range (0, 1f) * 2) - 1;
		int y_direction = (int)(Random.Range (0, 1f) * 2) - 1;
		//Debug.Log (x_direction + " " + y_direction);
		float x_offset, y_offset;
		if (x_direction == 0)
			x_offset = -Random.Range (0.5f, radius);
		else
			x_offset = Random.Range (0.5f, radius);
		if (y_direction == 0)
			y_offset = -Random.Range (0.5f, radius);
		else
			y_offset = Random.Range (0.5f, radius);

		Instantiate (orb, new Vector3(current_position.position.x+x_offset,current_position.position.y+y_offset,0), Quaternion.identity);
	}

	void spawn_enemy() {
		int x_direction = (int)(Random.Range (0, 1f) * 2) - 1;
		int y_direction = (int)(Random.Range (0, 1f) * 2) - 1;
		//Debug.Log (x_direction + " " + y_direction);
		float x_offset, y_offset;
		if (x_direction == 0)
			x_offset = -Random.Range (0.5f, radius);
		else
			x_offset = Random.Range (0.5f, radius);
		if (y_direction == 0)
			y_offset = -Random.Range (0.5f, radius);
		else
			y_offset = Random.Range (0.5f, radius);

		Instantiate (enemy, new Vector3(current_position.position.x+x_offset,current_position.position.y+y_offset,0), Quaternion.identity);
	}
}
