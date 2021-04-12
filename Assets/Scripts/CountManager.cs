using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountManager : MonoBehaviour
{
    private int woodCount;
    private int eraserCount;
    public GameObject stoveWood1;
    public GameObject stoveWood2;

    void Start()
    {
        woodCount = 0;
        eraserCount = 0;
    }

    public void IncreaseWoodCount()
    {
        woodCount++;
        Debug.Log(woodCount);
        if (woodCount == 1)
        {
            stoveWood1.SetActive(true);
        }
        else if (woodCount >= 2)
        {
            stoveWood2.SetActive(true);
            // Win condition
            Debug.Log("All wood transported.");
        }
    }

    public void IncreaseEraserCount()
    {
        eraserCount++;
        Debug.Log(eraserCount);
        if (eraserCount >= 4)
        {
            // Win condition
            Debug.Log("Chalkboard successfully cleared.");
        }
    }
}
