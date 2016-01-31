using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour {
	public GameObject heart;	
	public GameObject[] health;
	public int current_health;

	void Start() {
		current_health = 5;
		health = new GameObject[5];
		for (int i = 0; i < 5; i++) {
			health [i] = (GameObject)Instantiate (heart);
			health [i].transform.SetParent (this.transform);
		}
	}

	void Update() {
		/*if (current_health > GameInformation.player_health) {
			for (int i = 4; i >= GameInformation.player_health && i > 0; i--) {
				health [i].SetActive (false);
				current_health--;
			}
		}
		else if (current_health < GameInformation.player_health) {
			for (int i = current_health-1; i < GameInformation.player_health && i < 5; i++) {
				health [i].SetActive (true);
				current_health++;
			}
		}
		*/
		for (int i = 0; i < GameInformation.player_health; i++)
			health [i].SetActive (true);
		if(GameInformation.player_health > -1)
			for (int i = GameInformation.player_health; i < 5; i++)
				health [i].SetActive (false);
	}
}
