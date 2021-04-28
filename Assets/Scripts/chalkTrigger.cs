using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chalkTrigger : MonoBehaviour
{
    public GameObject writing;
    bool activated = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ChalkObj"))
        {
            if (!activated)
            {
                writing.SetActive(true);
                activated = true;
            }
        }
    }
}
