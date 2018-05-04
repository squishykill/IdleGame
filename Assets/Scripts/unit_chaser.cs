using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit_chaser : Unit {
	List<int> hp_list = new List<int> { 2, 4,6, 8, 12 };
	List<int> atk_list = new List<int> { 2, 4, 6, 8, 10 };
	List<float> spd_list = new List<float> { 0.8f, 0.8f, 0.8f, 0.8f, 0.8f };
	List<float> chase_spd = new List<float> { 1.2f, 1.3f, 1.4f, 1.5f, 1.5f };


	private unit_chaser_detector detector;
	private int detected;
	private GameObject detectedObj;

	void Start () {
		hp = hp_list[0];
		atk = atk_list [0];
		spd = spd_list [0];
		updateDisplay ();
		//detector = GetComponent<unit_chaser_detector> ();
		//detected = 0;
	}
	// Update is called once per frame
	void Update () {
		step = spd * Time.deltaTime;
		/**
		step = spd * Time.deltaTime;
		detected = detector.Detection;
		detectedObj = detector.DetectedObject;
		if (detected == 1) {
			if (player == 1) {
				transform.position = Vector3.MoveTowards (transform.position, detectedObj.transform.position, step);
			}
		} else {
		*/
			
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
		updateDisplay ();
	}
}
