using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChecklist : MonoBehaviour
{
    public KeyCode openKey = KeyCode.E;

    public CheckForTalk checkForTalk;

    public Animator animator;

    public bool checklistIsOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(openKey) && checklistIsOpen)
        {
            animator.SetBool("openChecklist", false);

            checklistIsOpen = false;
        }
        else if (Input.GetKeyDown(openKey) && checkForTalk.canOpenChecklist && !checklistIsOpen)
        {
            animator.SetBool("openChecklist", true);

            checklistIsOpen = true;
        }
    }
}
