using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicieCheck : MonoBehaviour
{
    public CheckForTalk checkForTalk;

    public GameObject checkForTalkObject;

    public bool pMedInTrigger;
    public bool bMedInTrigger;
    public bool gMedInTrigger;

    private void Start()
    {
        checkForTalk = checkForTalkObject.GetComponent<CheckForTalk>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pink Medicine")
        {
            pMedInTrigger = true;
        }

        if (other.tag == "Blue Medicine")
        {
            bMedInTrigger = true;
        }

        if (other.tag == "Green Medicine")
        {
            gMedInTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Pink Medicine")
        {
            pMedInTrigger = false;
        }

        if (other.tag == "Blue Medicine")
        {
            bMedInTrigger = false;
        }

        if (other.tag == "Green Medicine")
        {
            gMedInTrigger = false;
        }
    }

    void update()
    {
        if (checkForTalk.npcName = ("Test NPC"))
        {
            if (pMedInTrigger)
            {

            }
        }
    }
}
