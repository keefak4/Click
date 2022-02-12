using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomClick : MonoBehaviour
{
    [SerializeField] private Text RandText;
    [SerializeField] private int min;
    [SerializeField] private int max;
    
    public void ClickButton()
    {
        RandText.text = Random.Range(min, max).ToString();
        
    }
}
