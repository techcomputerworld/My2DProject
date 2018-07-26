using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaFalling : MonoBehaviour {

    public float fallDelay = 1f;
    public float respawnDelay = 5f;

    private Rigidbody2D rb2d;
    private PolygonCollider2D pc2d;
    //posicion inicial de la plataforma para luego hacer el respawn reaparicion 
    private Vector3 start;
    //private BoxCollider2D bc2d;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        pc2d = GetComponent<PolygonCollider2D>();
        start = transform.position;
        //bc2d = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
                
            Invoke("Fall", fallDelay);
            Invoke("Respawn", fallDelay + respawnDelay);
            

            
        }
        
    }
    //cuando colisionen 2 plataformas moviles PlataformaFalling y PlataformaMovil 
    private void Fall()
    {
        //poniendo esta propiedad en falso, volvera a ser un objeto dinamico y le volvera a afectar la gravedad
        rb2d.isKinematic = false;
        // con la propiedad isTrigger a true pasa por encima y claro esta no se mueve
        pc2d.isTrigger = true;
    }
    private void Respawn()
    {
        transform.position = start;
        rb2d.isKinematic = true;
        rb2d.velocity = Vector3.zero;
        pc2d.isTrigger = false;
    }

}
