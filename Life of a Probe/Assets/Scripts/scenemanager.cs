using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class scenemanager : MonoBehaviour {
	void Start() {
		Invoke ("Main_Menu", 3f);
	}

	public void Main_Menu() {
		Application.UnloadLevel ("Credit");
		Application.LoadLevel ("Menu Screen");
	}
}
