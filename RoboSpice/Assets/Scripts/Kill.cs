using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public GameObject Player;
    public GameObject Spawn;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            Player.transform.position = new Vector2(Spawn.transform.position.x, Spawn.transform.position.y);
        }
    }

}
