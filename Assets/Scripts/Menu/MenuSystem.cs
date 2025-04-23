using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	private Animator animator;
	[SerializeField] private AnimationClip finalAnimation;

	private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Play()
    {
        StartCoroutine(LoadNextScene());
    }

    public void Exit()
    {
		StartCoroutine(LoadPreviousScene());
	}
    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator LoadNextScene()
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(finalAnimation.length);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	IEnumerator LoadPreviousScene()
	{
		Debug.Log("Intentando activar trigger 'Exit'");
		animator.SetTrigger("Exit");
		yield return new WaitForSeconds(finalAnimation.length);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
}