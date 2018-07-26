using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
    //se ejecuta una vez cuando el componente es activado 
	void Start ()
    {
		
	}
	
	// Update is called once per frame
    // Update se llama en cada Frame por segundo 
	void Update ()
    {
        transform.Translate(new Vector3(1f, 0f, 0f) * Time.deltaTime);
        transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);	
	}
}
