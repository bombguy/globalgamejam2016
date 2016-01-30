using UnityEngine;
using System.Collections;


public class Orb : MonoBehaviour {
	public float lifespan;

	// Use this for initialization
	void Start () {
		lifespan = Random.Range (5f, 10f);
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
			GameInformation.orb_count++;
			GameInformation.player_health--;
			Destroy (this.gameObject);
		}
	}
}


	

	