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
                activated = true;
                Debug.Log("Textbook picked up.");
                // Win condition for textbook picked up
            }
        }
    }
}
