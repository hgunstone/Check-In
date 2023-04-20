using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    public ButtonPress buttonPress;

    public Transform startTarget;
    public Transform endTarget;

    public float speed;

    void Update()
    {

        if(buttonPress.done == false)
        {
            Vector3 currentPos = transform.position;
            Vector3 targetPos = startTarget.position;
            transform.position = Vector3.MoveTowards(currentPos, targetPos, speed * Time.deltaTime);
        }

        if (buttonPress.done == true)
        {
            Vector3 currentPos = transform.position;
            Vector3 targetPos = endTarget.position;
            transform.position = Vector3.MoveTowards(currentPos, targetPos, speed * Time.deltaTime);
        }
    }
}