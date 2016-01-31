using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelCount : MonoBehaviour {

	// Use this for initialization
    public Text textarea;
    void Start()
    {
        textarea = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        textarea.text = "   Current Level: " + GameInformation.level.ToString();
    }
}
