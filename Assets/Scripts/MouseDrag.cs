using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    Rigidbody rb;

    public float distance;

    public bool touching = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        if(touching == false)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z - distance);

            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            transform.position = objPosition;

            rb.isKinematic = true;
        }

        void OnCollisionEnter(Collision collision)
        {
            touching = true;
        }
    }

    private void OnMouseUp()
    {
        rb.isKinematic = false;
    }
}
