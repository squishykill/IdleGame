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
						GameObject unit = Instantiate (unitListA [selectedUnitA], hit.point, Quaternion.identity);
						Unit u = unit.GetComponent<Unit> (); 
						u.setStats (gc.getUnitLevel (1, selectedUnitA), gc.getUnitHp (1, selectedUnitA), gc.getUnitAtk (1, selectedUnitA),
							gc.getUnitSpd (1, selectedUnitA), 1);
					}
				}
			}

			//Player2
			if (Input.GetMouseButtonDown (1)) {
				if (hitObj.tag == "sideB") {
					if (gc.spawnUnit (2, selectedUnitB)) {
						GameObject unit = Instantiate (unitListB [selectedUnitB], hit.point, Quaternion.identity);
						Unit u = unit.GetComponent<Unit> ();
						u.setStats (gc.getUnitLevel (2, selectedUnitB), gc.getUnitHp (2, selectedUnitB), gc.getUnitAtk (2, selectedUnitB),
							gc.getUnitSpd (2, selectedUnitB), 2);
					}
				}
			}
		}
	}

	public void setSelectedUnitA(int unit) {
		selectedUnitA = unit;
	}

	public void setSelectedUnitB(int unit) {
		selectedUnitB = unit;
	}
}
