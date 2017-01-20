using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour 
{
	public float m_UpperBound = 3.5f;
	public float m_LowerBound = -3.5f;
	public float m_Speed = 10f;

	void Update()
	{
		var pos = transform.position;
		
		if (Input.GetKey(KeyCode.Space))
		{
			pos.y += Time.deltaTime * m_Speed;
		}
		else
		{
			pos.y -= Time.deltaTime * m_Speed;
		}

		pos.y = Mathf.Clamp(pos.y, m_LowerBound, m_UpperBound);
		transform.position = pos;
	}
}
