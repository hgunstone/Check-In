using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public Camera cam;

    public CheckForTalk checkForTalk;

    public MedicieCheck medicieCheck;

    public KeyCode pressKey = KeyCode.E;

    float rayDistance = 15;

    public float DistanceX = 0.5f;
    public float DistanceY = 0.5f;

    void Start()
    {

    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = cam.ViewportPointToRay(new Vector3(DistanceX, DistanceY, 0));

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if (hit.collider.CompareTag("Button") && Input.GetKeyDown(pressKey))
            {
                if(checkForTalk.npcName == "Test NPC")
                {
                    //if ()
                    //{

                    //}
                }
            }
        }

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if (!hit.collider.CompareTag("Button"))
            {
                
            }
        }
    }
}