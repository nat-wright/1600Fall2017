using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {

	public Text input;
	public string password = "kittens";

	void Update () {
		if(input.text == password) {
			print("You know the password.");
		}
	}
}