using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveNPC : MonoBehaviour
{
    public Transform enterTarget;
    public Transform exitTarget;

    public float t;
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 a = transform.position;
        Vector3 b = enterTarget.position;
        transform.position = Vector3.MoveTowards(a, b, speed * Time.deltaTime);
    }
}