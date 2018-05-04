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

	public GameObject currentUnitA;
	public GameObject currentUnitB;

	public int selectedUnitA;
	public int selectedUnitB;

	private List<GameObject> unitListA;
	private List<GameObject> unitListB;

	public GameController gc;

	void Start() {
		unitListA = new List<GameObject> { minionPlayerA, runnerPlayerA, chaserPlayerA, tankerPlayerA };
		unitListB = new List<GameObject> { minionPlayerB, runnerPlayerB, chaserPlayerB, tankerPlayerB };
		selectedUnitA = 0; //set default minion
		selectedUnitB = 0;
	}

	void Update () {
		myRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (myRay, out hit)) {
			hitObj = hit.transform.gameObject;

			//Player1
			if (Input.GetMouseButtonDown (0)) {
				if (hitObj.tag == "sideA") {
					if (gc.spawnUnit (1, selectedUnitA)) {
						int level = gc.getUnitLevel (1, selectedUnitA);
						GameObject unit = Instantiate (unitListA [selectedUnitA], hit.point, Quaternion.identity);
						unit.SendMessage ("setPlayer", 1);
						unit.SendMessage ("setUnitLevel", level);
					}
				}
			}

			//Player2
			if (Input.GetMouseButtonDown (1)) {
				if (hitObj.tag == "sideB") {
					if (gc.spawnUnit (1, selectedUnitB)) {
						int level = gc.getUnitLevel (2, selectedUnitB);
						GameObject unit = Instantiate (unitListB [selectedUnitB], hit.point, Quaternion.identity);
						unit.SendMessage ("setPlayer", 2);
						unit.SendMessage ("setUnitLevel", level);
					}
				}
			}
		}
	}

	public void setSelectedUnitA(int unit) {
		selectedUnitA = unit;
	}

	public void setSelectedUnitB(int unit) {
		selectedUnitA = unit;
	}
}
