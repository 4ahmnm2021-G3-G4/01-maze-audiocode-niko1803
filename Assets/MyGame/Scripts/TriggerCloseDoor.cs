using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCloseDoor : MonoBehaviour
{
    public Animator entranceAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "HeadCollider")
        {
            entranceAnim.SetBool("closeDoor", true);
        }
    }
}
