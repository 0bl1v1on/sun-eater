using UnityEngine.UI;
using UnityEngine;

public class UITimer : MonoBehaviour 
{
	public Image m_TimeImage;

	void Update () 
	{
		m_TimeImage.fillAmount = (CrocodileController.instance.m_TimeLeft/CrocodileController.LIFETIME);
	}
}
