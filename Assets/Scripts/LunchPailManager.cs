using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunchPailManager : MonoBehaviour
{
    public LunchPail lunchPail;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LunchPailObj"))
        {
            if (GameObject.ReferenceEquals(other.gameObject, lunchPail.gameObject))
            {
                Debug.Log("The lunch pail has left the building.");
                // TODO
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("LunchPailObj"))
        {
            if (GameObject.ReferenceEquals(other.gameObject, lunchPail.gameObject))
            {
                // TODO
            }
        }
    }
}
