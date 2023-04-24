using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    public Transform enterTarget;
    public Transform exitTarget;

    public float speed;

    void Update()
    {
        Vector3 a = transform.position;
        Vector3 b = enterTarget.position;
        transform.position = Vector3.MoveTowards(a, b, speed * Time.deltaTime);
    }
}