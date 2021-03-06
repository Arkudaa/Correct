using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public float jumpForce;
    private bool isGrounded;
    public Transform groundPoint;
    public LayerMask whatisGround;
    private bool canDoubleJump;
    private Animator anim;
    private SpriteRenderer sr;
    public float bounceForce;
    public static MovingScript instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    public void Bounce()
    {
        rb.velocity = new Vector2(rb.velocity.x, bounceForce);
    }



    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundPoint.position, .3f, whatisGround);
        rb.velocity = new Vector2(moveSpeed*Input.GetAxis("Horizontal"), rb.velocity.y);
        if (isGrounded)
        {
            canDoubleJump = true;
        }
        if (Input.GetButtonDown("Jump"))
        {   

            if (isGrounded)
            {

                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                
            }
            else
            {
                if (canDoubleJump)
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                    canDoubleJump = false;
                }
            }
           
        }

        anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        anim.SetBool("isGrounded", isGrounded);
        if (rb.velocity.x < 0)
        {
            sr.flipX = true;
        }
        else if (rb.velocity.x > 0)
        {
            sr.flipX = false;
        }



    }

}
