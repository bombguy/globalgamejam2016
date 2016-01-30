using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {
	public static int orb_count;
	public static int player_health;
	public float timer;

	void Start() {
		orb_count = 0;
		player_health = 5;
		timer = 0;
	}

	void Update() {
		timer += Time.deltaTime;
		if (player_health < 5 && timer >= 3) {
			timer = 0;
			player_health++;
			Debug.Log ("HP: " + player_health);
		}
		if (player_health == 5) {
			Debug.Log ("IM full HP");
		}
	}
}
