using UnityEngine;

public class HorizontalScroller: MonoBehaviour 
{
	/// Must be even.
	public float m_XLimit = -10;
	public float m_Speed = 3f;

	void Update()
	{
		var pos = transform.position;
		pos.x -= Time.deltaTime * m_Speed;
		transform.position = pos;

		if (transform.position.x <= m_XLimit)
		{
			Destroy(gameObject);
		}
	}
}
