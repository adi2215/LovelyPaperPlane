using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("SampleScene 1");
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }

    public void Lose()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void ExitToGame() => Application.Quit();

    public Animator transition;

    public float transitionTime = 1f;

    public void LoadNextLevel(int Num)
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + Num));
    }

    IEnumerator LoadLevel(int levelIndex)
    {

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
