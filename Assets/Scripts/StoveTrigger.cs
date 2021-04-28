using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveTrigger : MonoBehaviour
{
    public GameObject stoveTrigger;
    bool activated = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!activated)
            {
                stoveTrigger.SetActive(true);
                activated = true;
                Debug.Log("Stove trigger activated");
            }
        }
    }
}
