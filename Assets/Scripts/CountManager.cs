using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountManager : MonoBehaviour
{
    private int woodCount;
    private int eraserCount;
    public GameObject chalkboardPiece1;
    public GameObject chalkboardPiece2;
    public GameObject chalkboardPiece3;
    public GameObject chalkboardPiece4;

    void Start()
    {
        woodCount = 0;
        eraserCount = 0;
    }

    public void IncreaseWoodCount()
    {
        woodCount++;
        Debug.Log(woodCount);
        if (woodCount >= 2)
        {
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
