using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTrigger : MonoBehaviour
{
    // TODO
    bool activated = false;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("AppleObj"))
        {
            if (!activated)
            {
                // TODO
                Debug.Log("Apple placed");
                activated = true;
            }
        }
    }
}
