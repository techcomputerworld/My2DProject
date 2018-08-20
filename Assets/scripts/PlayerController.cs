using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float life;
    public float maxSpeed = 10f;
    public float speed = 20f;
    public bool grounded;
    public bool attack;
    public float jumpPower = 6.5f;
    public float h;
    private Rigidbody2D rb2d;
    private Animator anim;
    private bool jump;
    private bool doubleJump;
    private bool run;
    // Use this for initialization
	void Start ()
    {
        //con esto obtenemos el Rigidbody2D que hemos añadido desde add componet en el componente Player que hemos creado
        // with this we get the Rigidbody2D that we have added since adding the component in the component player that we created
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
	}

    // Update is called once per frame
    void Update()
    {
        //con esto trabajamos sobre las 2 variables Speed y Grounded en cada fotograma para trabajar con ellas
        //with this we work on the 2 variables Speed and Grounded in each frame to work with them
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Grounded", grounded);
        anim.SetBool("Attack", attack);

        // Esta guapo que se pueda usar esto con algún objeto que coja del escenario y lo pueda usar esta característica
        // salto de precaución 
        // It's nice that you can use this with some object that you take from the stage and you can use this feature, caution jump
        if (grounded)
        {
            doubleJump = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Jump();
            
        }
        //correr run en ingles
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Run();
            
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            Run();
        }
        //atacar attack en ingles
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            anim.SetTrigger("Attack");
            Attack();
        }
        //poner attack a false 
        //AttackReset();
        /*if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            jump = true;
            doubleJump = true;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && grounded)
        {
            jump = true;
            doubleJump = true;
        }*/

    }
    private void Jump()
    {
        if (grounded)
        {
            jump = true;
            doubleJump = true;
        }
        else if (doubleJump)
        {
            jump = true;
            doubleJump = false;
        }
    }
    private void Run()
    {
        if (grounded)
        {
            run = true;
            maxSpeed = 8f;
        }

    }
    private void Attack()
    {
        attack = true;

    }
    private void AttackReset()
    {
        attack = false;
    }
    private void FixedUpdate()
    {
       
        Vector3 fixedVelocity = rb2d.velocity;
        h = Input.GetAxis("Horizontal");

        if(grounded)
        {
            rb2d.velocity = fixedVelocity;
            fixedVelocity.x *= 0.75f;
        }
        

        rb2d.AddForce(Vector2.right * speed * h);
        
        /* esto es mejor arreglarlo de otra forma
        if (rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }
        if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }
        */
        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);
        
        /* Comprobar si va en dirección izquierda valor h en negativo o en dirección derecha valor h en positivo.
         */
        if (h > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (h < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        if (jump)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0f);
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }
        if (attack)
        {
            //the source code for attack player 
            // código para el ataque del juegador
            attack = false;
        }
        Debug.Log(rb2d.velocity.x);
    }
    //metodo que lo que hace es que cuando nuestro muñeco se vaya de la escena visible volvera a la posicion indicada, solo para 
    //usarlo en desarrollo del videojuego mas bien.
    /*
    private void OnBecameInvisible()
    {
        transform.position = new Vector3(-2f, 0f, 0f);
    }*/



}
