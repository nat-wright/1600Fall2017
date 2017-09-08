using UnityEngine;

public class PowerUp : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter ()
	{
		gameObject.SetActive(false);
	}
}
