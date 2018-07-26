using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEnemy1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (transform.localScale.x < 0)
        {
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Enemy1"))
        {

        }
    }
}
