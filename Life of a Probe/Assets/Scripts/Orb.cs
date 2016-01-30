using UnityEngine;
using System.Collections;


public class Orb : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
		
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log (coll.gameObject.name);
		if (coll.gameObject.name == "Player")
			Destroy (this.gameObject);
	}
}


	

	