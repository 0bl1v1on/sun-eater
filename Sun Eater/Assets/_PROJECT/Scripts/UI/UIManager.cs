using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
	public enum GameState
	{

	}

	public static UIManager instance { get; private set; }
	public GameObject m_GameOverScreen;

	void Awake()
	{
		Time.timeScale = 0f;
		CrocodileController.onDeath += ShowGameOver;
	}

	void ShowGameOver()
	{
		m_GameOverScreen.SetActive(true);
	}
}
