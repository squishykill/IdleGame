using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit_chaser_detector : MonoBehaviour {

	private int detected = 0;
	private GameObject obj;

	public int Detection {
		get {
			return detected;
		}
		set {
			detected = value;
		}
	}

	public GameObject DetectedObject {
		get {
			return obj;
		}
		set {
			obj = value;
		}
	}

	void OnTriggerEnter(Collider col) {
		Debug.Log (col.gameObject.tag);
		if (col.gameObject.tag == "minionB") {
			Detection = 1;
			DetectedObject = col.gameObject;
		}
	}
	/*
	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "player2") {
			Detection = 0;
		}
	}*/
}
