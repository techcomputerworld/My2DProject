using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGroundEnemy : MonoBehaviour {

    
    private Rigidbody2D rb2d;
    private Enemy1Controller enemy1;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        enemy1 = GetComponent<Enemy1Controller>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Platform")
        {
            rb2d.velocity = new Vector3(0f, 0f, 0f);
            enemy1.transform.parent = col.transform;
            enemy1.grounded = true;
        }
    }
    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            enemy1.grounded = true;
        }
        if (col.gameObject.tag == "Platform")
        {
            enemy1.transform.parent = col.transform;
            enemy1.grounded = true;
        }

    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            enemy1.grounded = false;
        }
        if (col.gameObject.tag == "Platform")
        {
            enemy1.transform.parent = null;
            enemy1.grounded = false;
        }
    }
}
