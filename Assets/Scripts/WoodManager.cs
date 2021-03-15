using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodManager : MonoBehaviour
{
    public Wood wood;
    public CountManager countManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WoodObj"))
        {
            if (GameObject.ReferenceEquals(other.gameObject, wood.gameObject))
            {
                // TODO
            }
        }
    }

    void OnTriggerExit(Collider other)
    {

    }
}
