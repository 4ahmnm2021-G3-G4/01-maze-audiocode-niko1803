using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBasket : MonoBehaviour
   
{
    public bool needleInBox = false;
    public bool needleInBox1 = false;
    public bool needleInBox2 = false;
    public WallUp wu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "needle")
        {
            Debug.Log("NeedleTriggered");
            needleInBox = true;
        }
        else if (other.tag == "needle1")
        {
            Debug.Log("Needle1Triggered");
            needleInBox1 = true;
        }
        else if (other.tag == "needle2")
        {
            Debug.Log("Needle2Triggered");
            needleInBox2 = true;
        }

    }

    public void Update()
    {
        if (needleInBox && needleInBox1 && needleInBox2)
        {
           // wu.transform.position(12, 3, 10);

        wu.go.transform.position = new Vector3(12, 3, 10);
        }
    }
}
