using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenObject : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private bool isButtonClick;
    [SerializeField] private GameObject clickObject;

    public void ClickActiveObject()
    {
        GameObject clickObg = Instantiate(clickObject, transform.position, Quaternion.identity);
        Destroy(clickObg, 0.3f);
        _gameObject.SetActive(true);
        if (isButtonClick)
        {
            Invoke("ObjectFalseActive", 6f);
        }
    }
    private void ObjectFalseActive()
    {
        _gameObject.SetActive(false);
    }
}
