using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroll : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    private bool movingRight=true;
    private int flip =1;

    public Transform groundDetection;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(flip * speed, rb.velocity.y);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position,Vector2.down,2f);
        if (groundInfo.collider==false||groundInfo.collider==GameObject.FindGameObjectWithTag("Danger"))
        {
            if (movingRight==true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                flip = -1;
                movingRight = false;
            }
            else if (movingRight == false)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                flip = 1;
                movingRight = true;
            }
        }
    }
}
