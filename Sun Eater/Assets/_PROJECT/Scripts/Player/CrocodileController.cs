using UnityEngine;
using System.Collections;
using System;

public class CrocodileController : MonoBehaviour 
{
	public const float LIFETIME = 7;
	public static CrocodileController instance { get; private set; }
	public int score { get; private set; }
	public float m_TimeLeft;
	public static event Action onDeath = delegate { };
	public AudioSource m_Audio;
	public AudioClip[] m_CollectSounds;
	public Animator m_CollideEffect;

	void Awake()
	{
		instance = this;
		m_TimeLeft = 15;
	}

	void Update()
	{
		m_TimeLeft = Mathf.Max(0, m_TimeLeft-Time.deltaTime);

		if (m_TimeLeft <= 0)
		{
			StartCoroutine(Killed());
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.layer == Layers.OBSTACLE)
		{
			StartCoroutine(Killed());
		}
		else if (other.gameObject.layer == Layers.COLLECTABLE)
		{
			Collected();
		}
	}

	IEnumerator Killed()
	{
		Debug.Log("You have died!");
		m_CollideEffect.Play("ColliderIntro");
		yield return new WaitForSeconds(1.2f);
		Time.timeScale = 0; 
		onDeath();
		score = 0;

	}

	void Collected()
	{
		Debug.Log("Eat the sunshine!");
		m_TimeLeft = LIFETIME;
		score++;
		m_Audio.clip = m_CollectSounds[UnityEngine.Random.Range(0,m_CollectSounds.Length)];
		m_Audio.Play();
	}
}
