using UnityEngine;
using System.Collections;

public class special_monster : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D coll) {
		GameInformation.player_health--;
		Debug.Log (coll.gameObject.name);
	}
}
