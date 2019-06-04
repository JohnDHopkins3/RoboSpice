using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceAt : MonoBehaviour
{
    public Transform target;
    public float speed;
    

    
    void Update()
    {
        Vector3 vectorToTarget = target.position - transform.position;
        float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg);
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
    }
}
