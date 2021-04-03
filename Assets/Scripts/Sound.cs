using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip crum;
    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
          audio.PlayOneShot(crum);
        }
            
    }
}
