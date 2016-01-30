using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpecialCount : MonoBehaviour {
	public Text textarea;
	void Start() {
		textarea = GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		textarea.text = GameInformation.special_count.ToString();
	}
}
