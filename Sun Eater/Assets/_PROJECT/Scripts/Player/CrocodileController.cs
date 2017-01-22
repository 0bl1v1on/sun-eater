using UnityEngine;
using System;

public class CrocodileController : MonoBehaviour 
{
	public static CrocodileController instance { get; private set; }
	public int score { get; private set; }

	public static event Action onDeath = delegate { };

	void Awake()
	{
		instance = this;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.layer == Layers.OBSTACLE)
		{
			Killed();
		}
		else if (other.gameObject.layer == Layers.COLLECTABLE)
		{
			Collected();
		}
	}

	void Killed()
	{
		Debug.Log("You have died!");
		onDeath();
		score = 0;
	}

	void Collected()
	{
		Debug.Log("Eat the sunshine!");

		score++;
	}
}
