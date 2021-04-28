using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodManager : MonoBehaviour
{
    public Wood wood1;
    public Wood wood2;
    public Fire fire;
    public CountManager countManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WoodObj"))
        {
            if ((GameObject.ReferenceEquals(other.gameObject, wood1.gameObject)) || (GameObject.ReferenceEquals(other.gameObject, wood2.gameObject)))
            {
                countManager.IncreaseWoodCount();
                wood1.gameObject.SetActive(false);
                wood2.gameObject.SetActive(false);
                fire.gameObject.SetActive(true);
            }
        }
    }
}
