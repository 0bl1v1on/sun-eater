using UnityEngine;

public class CrocodileController : MonoBehaviour 
{
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
	}

	void Collected()
	{
		Debug.Log("Eat the sunshine!");
	}
}
