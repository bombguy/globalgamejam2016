using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManaCount : MonoBehaviour {
	public Text textarea;
	void Start() {
		textarea = GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		textarea.text = GameInformation.orb_count.ToString();
	}
}
