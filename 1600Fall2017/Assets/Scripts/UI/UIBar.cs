using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

	public Image bar;
	public float barTime = 0.1f;
	public float powerLevel = 0.1f;
	public float ammountToAdd = 0.01f;

	public enum PowerUpType
	{
		PowerUp,
		PowerDown
	}

	public PowerUpType powerUp;

	void OnTriggerEnter () {

		switch (powerUp)
		{
			case PowerUpType.PowerUp:
				StartCoroutine(PowerUpBar());
			break;

			case PowerUpType.PowerDown:
				StartCoroutine(PowerDownBar());
			break;
		}
	}


	IEnumerator PowerUpBar () {
		while (bar.fillAmmount < 1)
		{
			bar.fillAmmount += ammountToAdd;
			yield return new WaitForSeconds(barTime);
		}
	}
	IEnumerator PowerDownBar () {
		float tempAmmount = powerLevel;
		while (tempAmmount > 0)
		{
			tempAmmount -= ammountToAdd;
			bar.fillAmmount -= tempAmmount;
			yield return new WaitForSeconds(barTime);
		}
	}

}
