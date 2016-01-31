using UnityEngine;
using System.Collections;

public class FlameAnimation : MonoBehaviour {

    public SpriteRenderer sr;
    public BoxCollider2D bc;
    float cooldown = 0.0f;
	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();
        sr.enabled = false;
        bc.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!sr.enabled)
        {
            //sr.enabled = false;
            cooldown += Time.deltaTime;
            if (cooldown > 3)
            {
                sr.enabled = true;
                bc.enabled = true;
            }
        }
        else
        {
            cooldown -= Time.deltaTime;
            if (cooldown < 0)
            {
                bc.enabled = false;
                sr.enabled = false;
                cooldown = 0;
            }
        }
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
		if (coll.gameObject.name == "Player" && !GameInformation.power_up && GameInformation.god_mode < 0)
        {
            GameInformation.player_health--;
			GameInformation.god_mode = 1.5f;
            MusicManager.mfiles[1].Play();
        }
    }
}
