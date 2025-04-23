using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrincipalPage : MonoBehaviour
{
	private Animator animator;
	[SerializeField] private AnimationClip finalAnimation;

	void Start()
    {
		animator = GetComponent<Animator>();
	}

    void Update()
    {
        if (Input.anyKeyDown)
        {
			StartCoroutine(LoadNextScene());
		}
    }

	IEnumerator LoadNextScene()
	{
		animator.SetTrigger("Start");
		yield return new WaitForSeconds(finalAnimation.length);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
