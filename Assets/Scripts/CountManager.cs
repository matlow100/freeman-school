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
    public GameObject stoveWood1;
    public GameObject stoveWood2;
    public GameObject eraserTrigger;
    public GameObject bucketTrigger;


    void Start()
    {
        woodCount = 0;
        eraserCount = 0;
    }

    public void IncreaseWoodCount()
    {
        woodCount++;
        if (woodCount > 0)
        {
            stoveWood1.SetActive(true);
            stoveWood2.SetActive(true);
            Debug.Log("Wood transported.");
        }
    }

    public void IncreaseEraserCount()
    {
        eraserCount++;
        Debug.Log(eraserCount);
        if (eraserCount >= 4)
        {
            eraserTrigger.SetActive(true);
            bucketTrigger.SetActive(true);
            Debug.Log("Chalkboard successfully cleared.");
        }
    }
}
