using UnityEngine;
using System.Collections;


public class Orb : MonoBehaviour {
	public float lifespan;

	// Use this for initialization
	void Start () {
		
	}
		
	// Update is called once per frame
	void Update () {
		lifespan -= Time.deltaTime;
		if (lifespan < 0)
			Destroy (this.gameObject);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log (coll.gameObject.name);
		if (coll.gameObject.name == "Player") {
            MusicManager.mfiles[0].Play();
            GetComponent<SpriteRenderer>().enabled = false;
			GameInformation.orb_count++;
			GameInformation.timer = 0;
            GameInformation.score += 20;
			Destroy (this.gameObject);
		}
	}
}


	

	