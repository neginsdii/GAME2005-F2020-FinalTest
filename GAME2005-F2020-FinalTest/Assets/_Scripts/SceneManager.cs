using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
	//void Start()
	//{
	//	//Set Cursor to not be visible
	//	Cursor.lockState = CursorLockMode.None;
	//	Cursor.visible = true;
	//}
	public bool activate = false;
	public void GoToMain()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("Main", LoadSceneMode.Single);
	}
	public void GoToStart()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("Start", LoadSceneMode.Single);
	}
	public void ActivateScene()
	{
		activate = !activate;
	}
}

