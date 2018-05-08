using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit_chaser : Unit {

	//List<float> chase_spd = new List<float> { 1.2f, 1.3f, 1.4f, 1.5f, 1.5f };


	//public unit_chaser_detector detector;
	//private int detected;
	//private GameObject detectedObj;

	// Update is called once per frame
	void Update () {
		step = spd * Time.deltaTime;
		if (player == 1) {
			transform.Translate (Vector3.forward * step);
		} else {
			transform.Translate (-Vector3.forward * step);
		}
		/*
		if (detector != null) {


			detected = detector.Detection;
			if (detected == 1) {
				if (player == 1) {
					transform.position = Vector3.MoveTowards (transform.position, detector.DetectedObject.transform.position, step);
				}
			} else {
				if (player == 1) {
					transform.Translate (Vector3.forward * step);
				} else {
					transform.Translate (-Vector3.forward * step);
				}
			}
		}
		*/
	}

}
