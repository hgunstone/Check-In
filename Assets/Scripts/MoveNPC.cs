using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    public int npcNumber;

    public ButtonPress buttonPress;

    public Transform enterTarget;
    public Transform exitTarget;

    public float speed;

    public static bool convoOngoing = false;

    void Update()
    {
        if (convoOngoing == false)
        {
            if (npcNumber == buttonPress.talked)
            {
                transform.position = Vector3.MoveTowards(transform.position, enterTarget.position, speed * Time.deltaTime);
            }

            if (npcNumber < buttonPress.talked)
            {
                transform.position = Vector3.MoveTowards(transform.position, exitTarget.position, speed * Time.deltaTime);
            }
        }
    }
}