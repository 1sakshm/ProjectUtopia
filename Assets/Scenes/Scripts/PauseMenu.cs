using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void PauseGame ()
    {
        anim.SetInteger("Paused",1);
        anim.SetInteger("Resume",0);
        StartCoroutine(PauseCoroutine());
    }
    public void ResumeGame ()
    {
        anim.SetInteger("Resume",1);
        anim.SetInteger("Paused",0);
        StartCoroutine(ResumeCoroutine());
    }
    public void MainMenu()
    {
        anim.SetInteger("MainMenu",1);
        anim.SetInteger("Resume",0);
        anim.SetInteger("Paused",0);
        StartCoroutine(MM());
    }
    IEnumerator PauseCoroutine()
    {
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0.0001f;
    }
    IEnumerator ResumeCoroutine()
    {
        Time.timeScale = 1;
        yield return new WaitForSeconds(3);
    }
    IEnumerator MM()
    {
        Time.timeScale = 1;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainMenu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("SceneSwipe");
    }
}

