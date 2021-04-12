using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTest : MonoBehaviour
{
    Animator animator;
    int isTalkingHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        isTalkingHash = Animator.StringToHash("isTalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool isTalking = animator.GetBool(isTalkingHash);

    }
     void OnTriggerEnter(Collider other)
    {
        
    }
}
