using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpecialCount : MonoBehaviour {
	public Text textarea;
	public GameObject special_icon;

	void Start() {
		textarea = GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		if (GameInformation.special_count >= 0) {
			special_icon.GetComponent<Image> ().sprite = Resources.Load <Sprite> ("Sprites/AngelOrb");
		} else {
			special_icon.GetComponent<Image> ().sprite = Resources.Load <Sprite> ("Sprites/DragonOrb");
		}
		textarea.text = GameInformation.special_count.ToString();
	}
}
