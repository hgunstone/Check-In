using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedNumber : MonoBehaviour
{
    public DialogueManager dialogueManager;

    public MedicineCheck medicineCheck;
    public int medNumber;

    private void Update()
    {
        if (dialogueManager.endOfDia == true && !medicineCheck.pMedInTrigger)
        {
            dialogueManager.endOfDia = false;
        }

        if (dialogueManager.endOfDia == true && medicineCheck.pMedInTrigger)
        {
            Destroy(gameObject);
        }
    }
}