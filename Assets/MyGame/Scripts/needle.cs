using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{
    public bool inBasket;
    public Transform parentBasket;
    public Transform parentCollectible;

    // Start is called before the first frame update
    void Start()
    {
        inBasket = false;
    }

    private void Update()
    {
        if (inBasket)
        {
            gameObject.transform.SetParent(parentBasket.transform);
        }
        else
        {
            gameObject.transform.SetParent(null);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "BasketTrigger" && !inBasket)
        {
            inBasket = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "BasketTrigger" && inBasket)
        {
            inBasket = false;
        }
    }
}
