using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    private float timeBtwShots;
    public float startTimeBtwShots;
    public GameObject projectTile;
    private Transform player;
    public int speed=2;
    public float offset;
    public Transform shootPoint;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vectorToTarget = player.position - transform.position;
        float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg)+offset;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);

        if (timeBtwShots<=0)
        {
            if (transform.rotation.z >-180&& transform.rotation.z <0)
            {
                Instantiate(projectTile, shootPoint.position, (transform.rotation * Quaternion.Euler(0, 0, -50)));
            }
            else
            {
                Instantiate(projectTile, shootPoint.position, (transform.rotation * Quaternion.Euler(0, 0, 50)));
            }
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
        
    }
}
