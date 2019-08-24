using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyMenu : MonoBehaviour {

		public void EasyGame()
		{
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
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}

	}