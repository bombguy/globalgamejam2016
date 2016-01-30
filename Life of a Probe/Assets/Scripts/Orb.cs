using UnityEngine;
using System.Collections;


public class Orb : MonoBehaviour {

	Collider2D col;
	// Use this for initialization
	void Start () {
		col = GetComponent<Collider2D> ();
	}
		
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter (Collision collision)
	{
		if(collision.gameObject.name == "Player")
			
		Debug.Log("Contact");
		
		Destroy (this);
	}
}


	

	