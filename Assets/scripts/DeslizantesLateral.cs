using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeslizantesLateral : MonoBehaviour {

    
    //las variable la hemos formado por las mayusculas del BoxCollider bc2d
    private BoxCollider2D bc2d;
	// Use this for initialization
	void Start () {
        bc2d = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /*
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            bc2d.isTrigger = true;
        }
    }
    */
}
