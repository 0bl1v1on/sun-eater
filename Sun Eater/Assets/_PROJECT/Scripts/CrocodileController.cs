using UnityEngine;

public class CrocodileController : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other)
	{
		Killed();
	}

	void Killed()
	{
		Debug.Log("You have died!");
	}
}
