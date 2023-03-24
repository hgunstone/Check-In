using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForTalk : MonoBehaviour
{

    bool talkable;
    public LayerMask NPC;

    void Update()
    {
        talkable = Physics.Raycast(transform.position, Vector3.forward, 1f, NPC);

        Debug.Log("talkable");
    }
}
