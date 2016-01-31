using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {
	public static int orb_count;
	public static int special_count;
	public static int player_health;
	public static int[] orb_to_next_level;
    public static int level;

	public int hp_degen_time;
	public static float timer;
	public static float power_up_duration;
	public static bool power_up;


	void Start() {
		power_up = false;
		orb_count = 0;
		orb_to_next_level = new int[] {5, 11, 18, 26, 35, 45};
		special_count = 0;
		player_health = 5;
        level = 0;
	}

	void Update() {
		if (player_health <= 0) {
			Debug.Log ("GameOver");
		}

		timer += Time.deltaTime;
		power_up_duration -= Time.deltaTime;

		if (timer >= hp_degen_time) {
			player_health--;
			timer = 0;
		}
		power_up = power_up_duration > 0;
		if (power_up) {

		}
	}
}
