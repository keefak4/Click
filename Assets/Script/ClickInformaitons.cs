using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInformaitons : MonoBehaviour
{
    [SerializeField] private GameObject panelInformations;
    [SerializeField] private GameObject textNumber;
    
    public void ClickPanel()
    {
        panelInformations.gameObject.SetActive(true);
        textNumber.gameObject.SetActive(false);
    }
}
