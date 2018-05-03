using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

	Ray myRay;
	RaycastHit hit;
	private GameObject hitObj;
	public GameObject minionPlayerA;
	public GameObject runnerPlayerA;
	public GameObject chaserPlayerA;
	public GameObject tankerPlayerA;
	public GameObject minionPlayerB;
	public GameObject runnerPlayerB;
	public GameObject chaserPlayerB;
	public GameObject tankerPlayerB;


	public int selectedUnitA;
	public int selectedUnitB;

	public GameController gc;

	void Update () {
		myRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (myRay, out hit)) {
			hitObj = hit.transform.gameObject;

			if (Input.GetMouseButtonDown (0)) {
				if (hitObj.tag == "sideA") {
					//check which minion
					//check if player has gold
					//if so, summon, else, do nothing
					gc.checkGold(1, selectedUnitA);
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

	public void setSelectedUnit(int unit) {
		selectedUnitA = unit;
	}
}
