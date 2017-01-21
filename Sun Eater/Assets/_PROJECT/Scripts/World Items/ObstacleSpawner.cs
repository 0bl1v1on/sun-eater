using UnityEngine;

public class ObstacleSpawner : MonoBehaviour 
{
	public GameObject[] m_Obstacles;
	public float m_SpawnX = 15f;
	public float m_UpperBound = 3.5f;
	public float m_LowerBound = -3.5f;

	private float m_SpawnRate = 3;
	private float m_Timeout = 0f;

	private float m_SpawnRange;

	void Awake()
	{
		m_SpawnRange = m_UpperBound - m_LowerBound;	
	}

	void Update()
	{
		m_Timeout += Time.deltaTime;

		if (m_Timeout >= m_SpawnRate)
		{
			var rand = Random.Range(0, m_Obstacles.Length);
			var obj = Instantiate(m_Obstacles[rand], transform);

			var pos = obj.transform.position;
			pos.x = m_SpawnX;
			pos.y = m_LowerBound + (m_SpawnRange * Random.value);
			obj.transform.position = pos;

			m_Timeout = 0f;
		}
	}
}
