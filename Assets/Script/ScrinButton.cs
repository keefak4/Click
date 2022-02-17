using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrinButton : MonoBehaviour
{
    [SerializeField] private GameObject exitObject;
    [SerializeField] private GameObject openObject;
    [SerializeField] private GameObject clickFans;

    public void ClickButton()
    {
        GameObject clickPop = Instantiate(clickFans, transform.position, Quaternion.identity);
        Destroy(clickPop, 0.3f);
        openObject.SetActive(true);
        exitObject.SetActive(false);
    }
}
