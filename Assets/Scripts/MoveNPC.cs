using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    public float speed;
    void Start()
    {
        transform.Translate(-8, 0, 0 * Time.deltaTime * speed);
    }
}