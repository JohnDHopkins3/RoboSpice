using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    private GameObject Player;
    private GameObject Spawn;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Spawn = GameObject.FindGameObjectWithTag("Respawn");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.transform.position = new Vector2(Spawn.transform.position.x, Spawn.transform.position.y);
        }
    }

}
