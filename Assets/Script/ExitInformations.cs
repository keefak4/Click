using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitInformations : MonoBehaviour
{
    [SerializeField] private GameObject panelInformations;
    [SerializeField] private GameObject textNumber;

    public void ClickPanelExit()
    {
        panelInformations.gameObject.SetActive(false);
        textNumber.gameObject.SetActive(true);
    }
}
