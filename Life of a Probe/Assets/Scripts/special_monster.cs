using UnityEngine;
using System.Collections;

public class special_monster : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MusicManager.mfiles[2].Play();
	}
	
	// Update is called once per frame
	void Update () {
	

	}
	void OnTriggerEnter2D(Collider2D coll) {
		if (GameInformation.power_up && coll.gameObject.name == "Player") {
			GetComponent<ParticleSystem> ().Play ();
            MusicManager.mfiles[1].Play();
            GameInformation.score += (GameInformation.level+1) * 100;
			Camera.main.GetComponent<CameraShakeScript>().shakeAmount = .5f;
			Camera.main.GetComponent<CameraShakeScript>().shake = .5f;
			Destroy (this.gameObject, .5f);
		} else if (coll.gameObject.name == "Player" && !GameInformation.power_up && GameInformation.god_mode < 0){
			GameInformation.player_health--;
			GameInformation.god_mode = 1.5f;
		}
	}
}
