using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserManager : MonoBehaviour
{
    public Eraser eraser;
    public CountManager countManager;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("EraserObj"))
        {
            countManager.IncreaseEraserCount();
            this.gameObject.SetActive(false);
        }
    }
}
