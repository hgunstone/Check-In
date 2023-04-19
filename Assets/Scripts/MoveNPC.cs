using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    public Transform target;
    public float speed;

    void Update()
    {
        Vector3 currentPos = transform.position;
        Vector3 targetPos = target.position;
        transform.position = Vector3.MoveTowards(currentPos, targetPos, speed * Time.deltaTime);
    }
}