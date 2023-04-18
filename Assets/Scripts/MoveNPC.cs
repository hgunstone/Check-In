using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    public float speed = 3f;
    void Start()
    {
        Vector3 newPosition = new Vector3(4.8f, 2.3f, 35.7f);

        transform.Translate(newPosition * speed * Time.deltaTime);
    }
}