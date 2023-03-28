using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForTalk : MonoBehaviour
{
    Camera cam;

    public KeyCode talkKey = KeyCode.E;

    float rayDistance = 15;

    public float DistanceX = 0.5f;
    public float DistanceY = 0.5f;

    public Animator animator;

    public Dialogue dialogue;

    public bool canTalk = false;
    public bool talking = false;

    DialogueTrigger dialoguetrigger;

    DialogueManager dialogueManager;

    void Start()
    {
        cam = GetComponent<Camera>();

        dialogueManager = GetComponent<DialogueManager>();
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = cam.ViewportPointToRay(new Vector3(DistanceX, DistanceY, 0));

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if (hit.collider.CompareTag("NPC"))
            {
                animator.SetBool("talkable", true);
                dialoguetrigger = hit.collider.gameObject.GetComponent<DialogueTrigger>();
                canTalk = true;
            }
            if (hit.collider.CompareTag("Environment"))
            {
                animator.SetBool("talkable", false);

                canTalk = false;
            }
        }  

        if(canTalk && Input.GetKeyDown(talkKey))
        {
            //start dialogue
            dialoguetrigger.TriggerDialogue();

            talking = true;
        }

        if(talking && Input.GetKeyDown(talkKey))
        {
            dialogueManager.DisplayNextSentence();
        }
    }
}
