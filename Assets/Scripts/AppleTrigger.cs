using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleTrigger : MonoBehaviour
{
    public Apple apple;
    public Text text;
    bool activated = false;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("AppleObj"))
        {
            if (!activated)
            {
                Debug.Log("Apple placed.");
                activated = true;
                text.gameObject.SetActive(true);
            }
        }
    }
}
