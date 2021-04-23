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
            stoveTrigger.SetActive(true);
            activated = true;
            Debug.Log("The wood has left the pile");
        }
    }
}
