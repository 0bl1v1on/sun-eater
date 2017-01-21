using UnityEngine;

/// <summary>
/// A horizontal scroller that checks for collisions with the player.
/// </summary>
public class ItemHorizontalScroller : HorizontalScroller 
{
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.layer == Layers.PLAYER)
		{
			Debug.LogFormat("The crocodile has eaten the obstacle {0}", name);
		}
	}

}
