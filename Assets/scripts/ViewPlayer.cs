using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewPlayer : MonoBehaviour {

    public float speed = 0f;
    //public float maxSpeed = 0f;
    
    public GameObject followPlayer;
    public GameObject Enemy1Controller;

    private bool follow;
    /* velocidades que usare para cuando se ponga a perseguir al enemigo */
    

    Vector3 initialPosition;

  

    // Use this for initialization
    void Start () {
        //posicion inicial del jugador que estara guardada 
        initialPosition = Enemy1Controller.transform.position;
        //Enemy1Controller.GetComponent<ViewPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    
    private void FixedUpdate()
    {
        //el codigo de movimiento del personaje enemigo lo voy a hacer aquí 
        // the code of movement enemy going to do here
        if (follow)
        {
            float fixedSpeed = speed * Time.deltaTime;
            //Enemy1Controller.transform.position = Vector3.MoveTowards(followPlayer.transform.position, Enemy1Controller.transform.position, fixedSpeed);
        }
        else
        {
            float fixedSpeed = speed * Time.deltaTime;
            //transform.position = Vector3.MoveTowards(transform.position, initialPosition, fixedSpeed);
        }
        //pintara una linea para la depuración solamente 
        Debug.DrawLine(transform.position, Enemy1Controller.transform.position, Color.green);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            follow = true;
            
        }
        else
        {
            follow = false;
            
        }
    }
}
