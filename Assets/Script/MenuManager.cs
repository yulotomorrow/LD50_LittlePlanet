using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	public void quitGame()
	{
		Application.Quit();
	}

	public void GotoStart()
	{
		SceneManager.LoadScene("TitleScene", LoadSceneMode.Single);
	}

	public void SuccessRestartMenu()
	{
		SceneManager.LoadScene("EndScene2", LoadSceneMode.Single);
	}

	public void StartGame()
	{
		SceneManager.LoadScene("IntroScene", LoadSceneMode.Single);
	}

	public void GotoGame()
	{
		SceneManager.LoadScene("AstroidScene", LoadSceneMode.Single);
	}
}
