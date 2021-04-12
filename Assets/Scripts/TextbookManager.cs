using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextbookManager : MonoBehaviour
{
    public Textbook textbook;
    bool activated = false;

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("TextbookObj"))
        {
            if (!activated)
            {
                // TODO
                Debug.Log("Textbook picked up.");
                activated = true;
            }
        }
    }
}
