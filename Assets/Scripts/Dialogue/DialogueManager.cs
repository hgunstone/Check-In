using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    public Dialogue currentIntro;
    public Dialogue currentPositive;
    public Dialogue currentNegative;

    public CheckForTalk checkForTalk;

    public MedicineReset medicineReset;
    MedicineCheck medicineCheck;

    public int dialogueEnded;

    public bool endOfDia;

    void Start()
    {
        sentences = new Queue<string>();
        medicineCheck = FindObjectOfType<MedicineCheck>();
    }

    private void Update()
    {
        if (endOfDia && !medicineCheck.pMedInTrigger)
        {
            endOfDia = false;
        }
        else if (endOfDia && medicineCheck.pMedInTrigger)
        {
            medicineCheck.RemoveMedicine();

            endOfDia = false;
        }
    }

    public void TriggerIntroDialogue()
    {
        StartDialogue(currentIntro);
    }

    public void TriggerNegativeDialogue()
    {
        StartDialogue(currentNegative);
    }

    public void TriggerPositiveDialogue()
    {
        StartDialogue(currentPositive);
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log(dialogue.name);

        MoveNPC.convoOngoing = true;

        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();

        if (sentence == "XXX-EndConvo")
        {
            dialogueEnded++;
            endOfDia = true;
            checkForTalk.talking = false;
            MoveNPC.convoOngoing = false;
            EndDialogue();
            return;
        }

        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
}