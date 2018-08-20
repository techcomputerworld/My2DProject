using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour {

    private PlayerController player;
    // Use this for initialization
    void Start () {
        player = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
   	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy1")
        {
            
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy1")
        {
            
            //aquí pondre que se hagan mas cosas de Inteligencia artificial
            // Here, I'll put more artificial intelligence stuff
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy1")
        {
            
        }
    }
}
