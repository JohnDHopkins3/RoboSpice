using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject Self;
    public GameObject dustEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.attachedRigidbody.velocity = Vector2.up*5;
            Instantiate(dustEffect, new Vector3(Self.transform.position.x, Self.transform.position.y, -5), Quaternion.identity);
            Destroy(Self);
        }
    }
}
