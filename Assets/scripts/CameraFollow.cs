using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject follow;
    public Vector2 minCamPos, maxCamPos;
    //suavizado de movimiento segun el tiempo de seguimiento de la camara al jugador 
    public float smoothTimeX;
    public float smoothTimeY;
    //este vector2 lo vamos a utilizar como variable interna para gestionar la velocidad a la que se esta moviendo la camara, en horiz
    private Vector2 velocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        //float posX = follow.transform.position.x;
        //float posY = follow.transform.position.y;
        float posX = Mathf.SmoothDamp(transform.position.x, follow.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, follow.transform.position.y, ref velocity.y, smoothTimeY);
        //probamos a poner solo que nos siga en posX y en posY y el ejeZ dejarlo a 0f
        transform.position = new Vector3(
            Mathf.Clamp(posX, minCamPos.x, maxCamPos.x), 
            Mathf.Clamp(posY, minCamPos.y, maxCamPos.y), 
            transform.position.z);

    }
}
