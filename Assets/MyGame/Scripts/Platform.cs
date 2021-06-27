using UnityEngine;

public class Platform : MonoBehaviour
{
    public bool isBasketOnPlatform;

    private void Start()
    {
        isBasketOnPlatform = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        
        if (collision.gameObject.name == "Basket" && !isBasketOnPlatform)
        {
            isBasketOnPlatform = true;
            Debug.Log("Platform collision with " + collision.gameObject.name);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Basket" && isBasketOnPlatform)
        {
            isBasketOnPlatform = false;
            Debug.Log("Exit Platform collision with " + collision.gameObject.name);
        }
    }
}
