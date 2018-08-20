using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    private PlayerController player1;
    private Enemy1Controller enemy1;
    // Use this for initialization
    void Start () {
        player1 = GetComponentInParent<PlayerController>();
        enemy1 = GetComponent<Enemy1Controller>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enemy1.chase = true;
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enemy1.chase = true;
            //aquí pondre que se hagan mas cosas de Inteligencia artificial
            // Here, I'll put more artificial intelligence stuff
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enemy1.chase = false;
        }
    }

    /*
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enemy1.chase = true;
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enemy1.chase = false;
        }
    }
    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enemy1.chase = true;
            //aquí pondre que se hagan mas cosas de Inteligencia artificial
            // Here, I'll put more artificial intelligence stuff
        }
    }*/
}
