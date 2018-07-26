using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovil : MonoBehaviour {

    public Transform target;
    public float speed;

    private Vector3 start, end;
    // Use this for initialization
	void Start () {
		if(target != null)
        {
            target.parent = null;
            start = transform.position;
            end = target.position;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        if (target != null)
        {
            float fixedSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, fixedSpeed);
        }

        if (transform.position == target.position)
        {
            /* verifica que el target.position este en start, si es asi iremos hacia end, si esta en donde end, iremos hacia start*/
            target.position = (target.position == start) ? end : start;
        }
    }
}
