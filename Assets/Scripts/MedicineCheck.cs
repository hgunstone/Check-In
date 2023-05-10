using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineCheck : MonoBehaviour
{
    public bool pMedInTrigger;

    GameObject medicineInSlot = null;

    public void RemoveMedicine()
    {
        if (medicineInSlot != null)
        {
            Destroy(medicineInSlot);
            medicineInSlot = null;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pink Medicine")
        {
            pMedInTrigger = true;
            medicineInSlot = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Pink Medicine")
        {
            pMedInTrigger = false;
            medicineInSlot = null;
        }
    }
}