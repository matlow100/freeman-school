using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class TriggerActivation : MonoBehaviour
{
    public string compareTag = "Player";

    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;
    public UnityEvent onTriggerStay;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(compareTag))
        {
            onTriggerEnter.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(compareTag))
        {
            onTriggerExit.Invoke();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(compareTag))
        {
            onTriggerStay.Invoke();
        }
    }
    
}
