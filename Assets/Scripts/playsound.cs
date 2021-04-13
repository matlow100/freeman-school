using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{
    public AudioClip SoundtoPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered trigger");
        Debug.Log(other.gameObject.tag);
        Debug.Log(other.gameObject);
        if (other.gameObject.CompareTag("Player"))
        {
            if (!alreadyPlayed)
            {
                audio.PlayOneShot(SoundtoPlay, Volume);
                alreadyPlayed = true;
            }
        }
    }
}
