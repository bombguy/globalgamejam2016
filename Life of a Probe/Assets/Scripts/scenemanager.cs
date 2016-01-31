using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class scenemanager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke( "ChangeLevel", 3.0f );
	}

	void ChangeLevel() {
		SceneManager.LoadScene ("Menu Screen");
	}
}
