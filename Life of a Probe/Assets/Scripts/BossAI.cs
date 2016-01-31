using UnityEngine;
using System.Collections;

public class BossAI : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.05F;
    public Vector2 directionOfPlayer;


    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        //flames = GetComponents<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
            directionOfPlayer = player.transform.position - transform.position;
            directionOfPlayer = directionOfPlayer.normalized;
            transform.Translate(directionOfPlayer * speed / (3 - (GameInformation.level * .2f)), Space.World);
    }
}