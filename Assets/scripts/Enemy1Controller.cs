using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Controller : MonoBehaviour {
    public float maxSpeed = 1f;
    public float speed = 1f;
    //este valor valdra 1 o -1
    public float h;
    public Transform target;

    private Vector3 start, end;
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
         
        if (target != null)
        {
            target.parent = null;
            start = transform.position;
            end = target.position;
            if (target.position.x < transform.position.x)
            {
                h = -1;
            }
            else if (target.position.x > transform.position.x)
            {
                h = 1;
            }
        }
       
        
    }
	
	// Update is called once per frame
	void Update () {
      
        
    }

    private void FixedUpdate()
    {
        //movimiento del enemigo la direccion la controlaremos con la variable speed si es positiva ira hacia la derecha si es negativa ira a la izquierda
        //enemy movement
        /*
        rb2d.AddForce(Vector2.right * speed * h);
        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);
        */
        Debug.Log("enemy " + rb2d.velocity);
        // Direccion hacia donde se mueve el enemigo
        if (target != null)
        {
            float fixedSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, fixedSpeed);
        }

        if (transform.position == target.position)
        {
            /* verifica que el target.position este en start, si es asi iremos hacia end, si esta en donde end, iremos hacia start*/
            target.position = (target.position == start) ? end : start;
            if (h == -1)
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
                h = 1;
            }
           
            if (target.position == start)
            {
                transform.localScale = new Vector3(-1f, 1f, 1f);
                h = -1;
            }

        }
       
        Debug.Log("horizontal" + h);

    }
}
