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
			if (gameObject.layer == Layers.COLLECTABLE)
			{
				Destroy(gameObject);
			}
		}
	}

}
