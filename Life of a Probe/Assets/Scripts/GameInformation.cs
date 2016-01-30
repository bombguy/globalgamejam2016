using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {
	public static int orb_count;
	public static int special_count;
	public static int player_health;

	public int hp_degen_time;
	public static float timer;

	void Start() {
		orb_count = 0;
		special_count = 0;
		player_health = 5;
	}

	void Update() {
		if (player_health <= 0) {
			Debug.Log ("GameOver");
		}
		timer += Time.deltaTime;
		if (timer >= hp_degen_time) {
			player_health--;
			timer = 0;
		}
	}
}
