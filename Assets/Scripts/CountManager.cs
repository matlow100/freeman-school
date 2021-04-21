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
    public GameObject TLTrigger;
    public GameObject TRTrigger;
    public GameObject BLTrigger;
    public GameObject BRTrigger;


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
        if (eraserCount == 1)
        {
            TLTrigger.SetActive(true);
        }
        else if (eraserCount == 2)
        {
            TRTrigger.SetActive(true);
        }
        else if (eraserCount == 3)
        {
            BLTrigger.SetActive(true);
        }
        else if (eraserCount >= 4)
        {
            BRTrigger.SetActive(true);
            eraserTrigger.SetActive(true);
            bucketTrigger.SetActive(true);
            Debug.Log("Chalkboard successfully cleared.");
        }
    }
}
