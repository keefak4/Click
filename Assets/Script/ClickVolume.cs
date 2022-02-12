using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickVolume : MonoBehaviour
{
    [SerializeField] private GameObject sliderVolume;
   
    public void ClickButtonVolumeTry()
    {
        sliderVolume.gameObject.SetActive(true);
        Invoke("SliderVolumeExit", 5f);
    }  
    private void SliderVolumeExit()
    {
        sliderVolume.gameObject.SetActive(false);
    }
}
