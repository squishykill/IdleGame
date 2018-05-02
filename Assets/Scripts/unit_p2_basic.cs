using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit_p2_basic : Unit {

	// Use this for initialization
	void Start () {
		hp = 2;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-Vector3.forward * Time.deltaTime);
	}
}
