using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDay : MonoBehaviour
{
    public DialogueManager dialogueManager;

    private void Update()
    {
        if(dialogueManager.dialogueEnded == 12)
        {
            StartCoroutine(LoadingScene());
        }
    }

    IEnumerator LoadingScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("End Scene");

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}