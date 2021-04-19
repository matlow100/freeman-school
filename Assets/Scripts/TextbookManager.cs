using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextbookManager : MonoBehaviour
{
    public Textbook textbook;
    bool activated = false;
    public GameObject deskTrigger;


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

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("TextbookObj"))
        {
            if (!activated)
            {
                activated = true;
                Debug.Log("Textbook picked up");
                deskTrigger.SetActive(true);
            }
        }
    }
}
