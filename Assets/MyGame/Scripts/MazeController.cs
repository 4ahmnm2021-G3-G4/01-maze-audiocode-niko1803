using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeController : MonoBehaviour
{
    public Needle[] needles;
    public Animator exitAnimator;
    public Platform targetPlatform;
    public TriggerCloseDoor entrance;



    bool AllNeedlesInBasket()
    {
        bool allInBasket = true;
        foreach (Needle elem in needles)
        {
            allInBasket = allInBasket && elem.inBasket;
        }

        return allInBasket;
    }
    public void Update()
    {
        if (AllNeedlesInBasket() && targetPlatform.isBasketOnPlatform)
        {
            exitAnimator.SetBool("openExit", true);
        }
    }
}
