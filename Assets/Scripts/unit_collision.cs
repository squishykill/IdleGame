using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit_collision : MonoBehaviour {

	private Unit unitA;
	private Unit unitB;

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "minionB") {
			unitA = GetComponent<Unit> ();
			unitB = col.gameObject.GetComponent<Unit> ();
			unitA.calculateDamage (unitB.getAttack ());
			unitB.calculateDamage (unitA.getAttack ());
		}
	}
}
