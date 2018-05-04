using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit_tanker : Unit {

	// Update is called once per frame
	void Update () {
		step = spd * Time.deltaTime;
		if (player == 1) {
			transform.Translate (Vector3.forward * step);
		} else {
			transform.Translate (-Vector3.forward * step);
		}
	}
}
