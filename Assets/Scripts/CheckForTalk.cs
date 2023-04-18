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

    public DialogueManager dialogueManager;

    public GameObject managerObject;

    public string npcName;

    void Start()
    {
        cam = GetComponent<Camera>();

        dialogueManager = managerObject.GetComponent<DialogueManager>();
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

                npcName = hit.collider.gameObject.name;
            }
            if (hit.collider.CompareTag("Environment"))
            {
                animator.SetBool("talkable", false);

                canTalk = false;
            }
        }  

        if(canTalk && !talking && Input.GetKeyDown(talkKey))
        {
            dialoguetrigger.TriggerDialogue();

            talking = true;
            canTalk = false;
        }

        if(canTalk && talking && Input.GetKeyDown(talkKey))
        {
            dialogueManager.DisplayNextSentence();
        }
    }
}
