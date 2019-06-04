using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletMovement : MonoBehaviour
{
    public float speed;
    private bool movedPast=false;
    private Transform player;
    private Vector2 target;
    public Transform forward;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        if (transform.position.y==target.y&&transform.position.x==target.x||movedPast==true)
        {
            transform.position = Vector2.MoveTowards(transform.position,forward.position, speed * Time.deltaTime);
            movedPast = true;
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        DestroyProjectile();
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
