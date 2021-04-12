using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunchPailManager : MonoBehaviour
{
    public LunchPail lunchPail;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("LunchPailObj"))
        {
            Debug.Log("The lunch pail has left the building.");
            // TODO
        }
    }
}
