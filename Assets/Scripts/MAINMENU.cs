using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MAINMENU : MonoBehaviour {

	public void Update()
	{
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Confined;
	}
	public void PlayGame()
	{
		Cursor.visible = true;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

	}

	public void QuitGame()
	{
		Debug.Log ("Quit!");
		Application.Quit ();
	}
	public void EasyGame()
	{
		Cursor.visible = true;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

	}

	public void MediumGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
	}
	public void HardGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 3);
	}
	public void BackGame()
	{
		Cursor.visible = true;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);

	}
	public void BackToMenu()
	{
		Cursor.visible = true;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 4);	
	}
	public void BackToMenu2()
	{
		Cursor.visible = true;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 5);	
	}

}