using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private string nameScene;
    [SerializeField] private GameObject audioClick;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ClickSceneLoad()
    {
        StartCoroutine(CorLoadScene());
    }
    private IEnumerator CorLoadScene()
    {
        GameObject click = Instantiate(audioClick, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        anim.SetTrigger("buttonExit");
        
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(nameScene);
    }
}
