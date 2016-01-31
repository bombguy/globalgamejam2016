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
			Destroy (this.gameObject, .3f);
		} else if (coll.gameObject.name == "Player" && !GameInformation.power_up){
			GameInformation.player_health--;
		}
	}
}
