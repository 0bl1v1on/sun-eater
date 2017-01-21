using UnityEngine;
using System.Collections.Generic;

public class RepeatingScrollerSpawner: MonoBehaviour 
{
	public GameObject m_ObjectPrefab;
	/// Must be even.
	public int m_Count = 1;
	public float m_RepeatingOffset;
	public float m_XLimit = -10;
	public float m_Speed = 1f;

	private Queue<GameObject> m_Objects = new Queue<GameObject>();


	void Awake()
	{
		var pos = m_ObjectPrefab.transform.position;
		
		for (int i = 0; i < m_Count; i++)
		{
			var obj = Spawn(i);
			m_Objects.Enqueue(obj);
		}
	}

	void Update()
	{
		foreach (var obj in m_Objects)
		{
			var pos = obj.transform.position;
			pos.x -= Time.deltaTime * m_Speed;
			obj.transform.position = pos;
		}

		if (m_Objects.Peek().transform.position.x <= m_XLimit)
		{
			Destroy(m_Objects.Dequeue());

			var obj = Spawn(m_Objects.Count);
			m_Objects.Enqueue(obj);
		}
	}

	GameObject Spawn(int repeatPosition)
	{
		var pos = m_ObjectPrefab.transform.position;
		var obj = Instantiate(m_ObjectPrefab, transform);
		obj.transform.localPosition = new Vector3(m_RepeatingOffset * repeatPosition, 0f, 0f);
		
		return obj;

	}
}
