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

    public void sound()
    {
        audio.PlayOneShot(crum);
    }
}
