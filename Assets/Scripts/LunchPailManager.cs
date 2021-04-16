using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunchPailManager : MonoBehaviour
{
    public LunchPail lunchPail;
    bool activated = false;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("LunchPailObj"))
        {
            if (!activated)
            {
                Debug.Log("The lunch pail has left the building.");
                activated = true;
                // TODO
            }
        }
    }
}
