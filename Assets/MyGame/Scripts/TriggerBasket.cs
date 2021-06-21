using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBasket : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "needle")
        {
            Debug.Log("NeedleTriggered");
        }
    }
}
