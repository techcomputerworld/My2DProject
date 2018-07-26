using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSceneLine : MonoBehaviour {

    //punto de inicio 
    public Transform from;
    //Punto de sai
    public Transform to;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDrawGizmos()
    {
        if (from != null && to != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(from.position, to.position);
            Gizmos.DrawSphere(from.position, 0.15f);
            Gizmos.DrawSphere(to.position, 0.15f);

        }
    }
}
