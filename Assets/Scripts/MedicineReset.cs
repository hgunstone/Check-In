using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineReset : MonoBehaviour
{

    public Transform medicine;

    public Vector3 startPos;

    public bool shouldReturn;

    private void Start()
    {
        startPos = medicine.position;
    }

    void Update()
    {
        if(shouldReturn)
        {
            medicine.position = startPos;

            shouldReturn = false;
        }
    }
}
