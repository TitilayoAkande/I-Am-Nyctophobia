using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    public float speed = 10f;
    private Rigidbody2D body;
    public float jumpHeight = 7f;
    private bool facingLeft = false;
    private new SpriteRenderer renderer;
    public  bool grounded = true;





    // Start is called before the first frame update
    void Awake() 
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        this.renderer = this.GetComponent<SpriteRenderer>();


    }
    void Start()
    {
       
    }

   

    
    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontlInput = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(Input.GetAxis("Horizontal")* speed,body.velocity.y); 

    

        if(Input.GetKey(KeyCode.Space)&& grounded)
        Jump();
       
        if (body.velocity.x < 0) {
            facingLeft = true;
        } else if (body.velocity.x > 0) {
            facingLeft = false;
        }

        renderer.flipX = facingLeft;

        anim.SetBool("running", horizontlInput !=0);
    
    }

void Update() 
{
    
}
    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpHeight);
        grounded = false; 
         anim.SetTrigger("jumped");
    }

   

    private void  OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Ground")
        {
              grounded = true;
        }
      
    }

   
}