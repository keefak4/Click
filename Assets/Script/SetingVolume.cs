using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetingVolume : MonoBehaviour
{
    private AudioSource audioSource;
    private float musicVolume = 0;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        audioSource.volume = musicVolume;
    }
    public void Volume(float vol)
    {
        musicVolume = vol;
    }

}
