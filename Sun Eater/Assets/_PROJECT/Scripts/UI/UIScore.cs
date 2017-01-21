using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour 
{
	public Text m_ScoreText;

	void Update () 
	{
		if (CrocodileController.instance != null)
		{
			m_ScoreText.text = string.Format("{0}", CrocodileController.instance.score);
		}
	}
}
