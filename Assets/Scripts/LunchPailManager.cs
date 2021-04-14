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
                activated = true;
                Debug.Log("The lunch pail has left the building.");
                // Win condition for lunch pail moved outside
            }
        }
    }
}
