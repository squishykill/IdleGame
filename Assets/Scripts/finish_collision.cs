using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish_collision : MonoBehaviour {

	public GameObject victory;
	public Text result;
	private string resultText;

	//issue: what if each team's minions hits finish at exact same time
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "minionB") {
			resultText = "Player B Wins!";
		}

		if (col.gameObject.tag == "minionA") {
			resultText = "Player A Wins!";
		}
		result.text = resultText;
		result.gameObject.SetActive (true);
		victory.gameObject.SetActive (true);
		Time.timeScale = 0;
	}
}
