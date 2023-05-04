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

    public DialogueManager dialogueManager;

    NPCDialogue currentDia;

    public GameObject managerObject;

    public int npcNum;

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

                currentDia = hit.collider.gameObject.GetComponent<NPCDialogue>();

                dialogueManager.currentIntro = currentDia.intro;
                dialogueManager.currentPositive = currentDia.positive;
                dialogueManager.currentNegative = currentDia.negative;

                npcNum = hit.collider.gameObject.GetComponent<NPCDialogue>().npcNumber;

                canTalk = true;
            }
            if (hit.collider.CompareTag("Environment"))
            {
                animator.SetBool("talkable", false);

                canTalk = false;
            }
        }  

        if(canTalk && !talking && Input.GetKeyDown(talkKey))
        {
            dialogueManager.TriggerIntroDialogue();

            talking = true;
            canTalk = false;
        }

        if(canTalk && talking && Input.GetKeyDown(talkKey))
        {
            dialogueManager.DisplayNextSentence();
        }
    }
}
