using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("staring animation...");
        Animation a = this.GetComponent<Animation>();
        a.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
