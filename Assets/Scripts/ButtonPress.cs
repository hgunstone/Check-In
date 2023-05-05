using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public Camera cam;

    public CheckForTalk checkForTalk;

    public MedicineCheck medicieCheck;

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
                if (checkForTalk.npcNum == talked)
                {
                    if (medicieCheck.pMedInTrigger)//the medicine the current NPC wants not just pink med
                    {
                        dialogueManager.TriggerPositiveDialogue();

                        talked++;
                    }

                    if (!medicieCheck.pMedInTrigger)
                    {
                        dialogueManager.TriggerNegativeDialogue();

                        talked++;
                    }
                }
            }
        }
    }
}