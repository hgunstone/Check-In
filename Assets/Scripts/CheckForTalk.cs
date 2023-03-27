using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForTalk : MonoBehaviour
{

    public bool talkable = false;
    public LayerMask NPC;

    void Update()
    {
        talkable = Physics.Raycast(transform.position, Vector3.forward, 10f, NPC);

        if(talkable = true)
        {
            Debug.Log("talkable");
        }
    }
}
