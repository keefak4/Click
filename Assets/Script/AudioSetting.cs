using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSetting : MonoBehaviour
{
    private AudioSource music;
    private float musicVolume = 1f;
    private void Start()
    {
        music = GetComponent<AudioSource>();
    }
    private void Update()
    {
        music.volume = musicVolume;
    }
    public void SliderVolime(float vol)
    {
        musicVolume = vol;
    }
}
