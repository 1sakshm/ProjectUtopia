using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void Game()
    {
        anim.SetInteger("Clicked",1);
        StartCoroutine(ExampleCoroutine());
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SceneSwipe");
    }
}
