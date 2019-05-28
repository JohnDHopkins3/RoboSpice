using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveImput;

    private Rigidbody2D rb;
    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsAmount;
    public GameObject dustEffect;
    private bool spawnDust;

    void Start()
    {
        extraJumps = extraJumpsAmount;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,whatIsGround);

        moveImput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveImput * speed, rb.velocity.y);

        if (facingRight==false&&moveImput>0)
        {
            Flip();
        }
        else if (facingRight==true&&moveImput<0)
        {
            Flip();
        }
    }

    private void Update()
    {
        if (isGrounded==true)
        {
            extraJumps = extraJumpsAmount;
            if (spawnDust==true)
            {
                Instantiate(dustEffect,new Vector3( groundCheck.position.x, groundCheck.position.y,-5), Quaternion.identity);
                spawnDust = false;
            }
        }
        else
        {
            spawnDust=true;
        }

        if (Input.GetButtonDown("Jump") && extraJumps>0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }
        else if (Input.GetButtonDown("Jump")&&extraJumps==0&&isGrounded==true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
