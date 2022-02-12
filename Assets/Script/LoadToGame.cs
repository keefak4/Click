using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadToGame : MonoBehaviour
{
    public void ButtonLoadToGame()
    {
        SceneManager.LoadScene(0);
    }
}
