using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextbookManager : MonoBehaviour
{
    public Textbook textbook;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TextbookObj"))
        {
            if (GameObject.ReferenceEquals(other.gameObject, textbook.gameObject))
            {
                // TODO
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TextbookObj"))
        {
            if (GameObject.ReferenceEquals(other.gameObject, textbook.gameObject))
            {
                // TODO
            }
        }
    }
}
