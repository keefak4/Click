using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickLogic : MonoBehaviour
{
    [SerializeField] private int minX;
    [SerializeField] private int maxX;
    [SerializeField]private Text textNumber;
    [SerializeField] private GameObject clickRandom;
    public void Click()
    {
        GameObject click = Instantiate(clickRandom, transform.position, Quaternion.identity);
        Destroy(click, 0.3f);
        textNumber.text = Random.Range(minX, maxX).ToString();

    }

}
