using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public Camera cam;

    public CheckForTalk checkForTalk;

    public MedicineCheck medicineCheck;

    public DialogueManager dialogueManager;

    public MoveNPC moveNPC;

    public KeyCode pressKey = KeyCode.E;

    float rayDistance = 15;

    public float DistanceX = 0.5f;
    public float DistanceY = 0.5f;

    public int talked = 0;

    public void Update()
    {
        RaycastHit hit;
        Ray ray = cam.ViewportPointToRay(new Vector3(DistanceX, DistanceY, 0));

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if (hit.collider.CompareTag("Button") && Input.GetKeyDown(pressKey))
            {
                //medicineReset.shouldReturn = true;

                if (checkForTalk.npcNum == talked)
                {
                    if (medicineCheck.pMedInTrigger)
                    {
                        dialogueManager.TriggerPositiveDialogue();

                        talked++;
                    }

                    if (!medicineCheck.pMedInTrigger)
                    {
                        dialogueManager.TriggerNegativeDialogue();

                        talked++;
                    }
                }
            }
        }
    }
}