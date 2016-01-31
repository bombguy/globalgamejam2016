using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    static public AudioSource[] mfiles; 

	// Use this for initialization
	void Start () {
        mfiles = GetComponents<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    static void playAudio(int x)
    {
        mfiles[x].Play();
    }
}
