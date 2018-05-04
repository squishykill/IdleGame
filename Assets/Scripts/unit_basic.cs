using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unit_basic : Unit {
	List<int> hp_list = new List<int> { 1, 2, 3, 4, 5 };
	List<int> atk_list = new List<int> { 1, 2, 3, 4, 5 };
	List<float> spd_list = new List<float> { 1f, 1f, 1f, 1f, 1f };


	void Start () {
		hp = hp_list[0];
		atk = atk_list [0];
		spd = spd_list [0];
		updateDisplay ();
	}
	// Update is called once per frame
	void Update () {
		step = spd * Time.deltaTime;
		if (player == 1) {
			transform.Translate (Vector3.forward * step);
		} else {
			transform.Translate (-Vector3.forward * step);
		}
	}

	public void setUnitLevel(int level) {

		hp = hp_list[level];
		atk = atk_list [level];
		spd = spd_list [level];
		Debug.Log ("Update unit" + hp);
		hp_display.text = hp.ToString ();
	}
}
