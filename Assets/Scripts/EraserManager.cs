using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserManager : MonoBehaviour
{
    public Eraser eraser;
    public CountManager countManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EraserObj"))
        {
            if (GameObject.ReferenceEquals(other.gameObject, eraser.gameObject))
            {
                countManager.IncreaseEraserCount();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("EraserObj"))
        {
            if (GameObject.ReferenceEquals(other.gameObject, eraser.gameObject))
            {
                countManager.DecreaseEraserCount();
            }
        }
    }
}
