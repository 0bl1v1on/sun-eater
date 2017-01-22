using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
	public static UIManager instance { get; private set; }

	public GameObject m_GameOverScreen;
	public GameObject m_GameScreen;
	
	void Awake()
	{
		Pause();
		CrocodileController.onDeath += ShowGameOver;
	}

	public void Pause()
	{
		Time.timeScale = 0f;
	}

	public void Resume()
	{
		Time.timeScale = 1f;
	}

	public void NewGame()
	{
		Resume();
	}


	public void RestartGame()
	{
		SceneManager.LoadScene("Main");
	}

	void ShowGameOver()
	{
		Pause();
		
		m_GameScreen.SetActive(false);
		m_GameOverScreen.SetActive(true);
	}
}
