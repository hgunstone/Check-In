using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineCheck : MonoBehaviour
{
    public CheckForTalk checkForTalk;

    public DialogueManager dialogueManager;

    public bool pMedInTrigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pink Medicine")
        {
            pMedInTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Pink Medicine")
        {
            pMedInTrigger = false;
        }
    }

    private void Update()
    {
        if(dialogueManager.endOfDia == true && !pMedInTrigger)
        {
            dialogueManager.endOfDia = false;
        }

        if (dialogueManager.endOfDia == true && pMedInTrigger)
        {
            
        }
    }
}