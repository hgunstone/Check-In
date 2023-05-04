using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicieCheck : MonoBehaviour
{
    public CheckForTalk checkForTalk;

    public bool pMedInTrigger;
    public bool bMedInTrigger;
    public bool gMedInTrigger;

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
}