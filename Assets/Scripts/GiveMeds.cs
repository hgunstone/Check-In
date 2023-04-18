using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveMeds : MonoBehaviour
{

    public DialogueManager dialogueManager;

    public GameObject managerObject;

    public GameObject medicine;

    void Start()
    {
        dialogueManager = managerObject.GetComponent<DialogueManager>();
    }
    void Update()
    {
        if (dialogueManager.talked)
        {

        }
    }
}
