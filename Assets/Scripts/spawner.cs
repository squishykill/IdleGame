using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

	Ray myRay;
	RaycastHit hit;
	private GameObject hitObj;
	public GameObject minionPlayerA;
	public GameObject minionPlayerB;

	void Update () {
		myRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (myRay, out hit)) {
			hitObj = hit.transform.gameObject;

			if (Input.GetMouseButtonDown (0)) {
				if (hitObj.tag == "sideA") {
					GameObject unit = Instantiate (minionPlayerA, hit.point, Quaternion.identity);
					unit.SendMessage ("setPlayer", 1);
				}
			}

			if (Input.GetMouseButtonDown (1)) {
				if (hitObj.tag == "sideB") {
					GameObject unit = Instantiate (minionPlayerB, hit.point, Quaternion.identity);
					unit.SendMessage ("setPlayer", 2);
				}
			}
		}
	}
}
