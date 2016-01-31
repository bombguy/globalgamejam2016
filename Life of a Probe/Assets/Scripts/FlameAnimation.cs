using UnityEngine;
using System.Collections;

public class FlameAnimation : MonoBehaviour {

    public SpriteRenderer sr;
    float cooldown = 0.0f;
	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        sr.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!sr.enabled)
        {
            //sr.enabled = false;
            cooldown += Time.deltaTime;
            if (cooldown > 3)
                sr.enabled = true;
        }
        else
        {
            cooldown -= Time.deltaTime;
            if (cooldown < 0)
            {
                sr.enabled = false;
                cooldown = 0;
            }
        }
	}
}
