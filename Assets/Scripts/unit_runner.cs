using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit_runner : Unit {
	List<int> hp_list = new List<int> { 1, 2, 3, 4, 5 };
	List<int> atk_list = new List<int> { 1, 2, 3, 4, 5 };
	List<float> spd_list = new List<float> { 1.2f, 1.2f, 1.3f, 1.3f, 1.5f };
	List<int> upgrade_list = new List<int> { 40, 70, 120, 180, 200 };
	List<int> spawn_list = new List<int> { 20, 40, 60, 80, 100 };
	List<int> gold_production_list = new List<int> { 2, 3, 4, 5, 6 };

	void Start () {
		hp = hp_list[0];
		atk = atk_list [0];
		spd = spd_list [0];
		upgradeCost = upgrade_list[0];
		spawnCost = spawn_list[0];
		gold_production = gold_production_list[0];
	}
	// Update is called once per frame
	void Update () {
		step = spd * Time.deltaTime;
		if (player == 1) {
			transform.Translate (Vector3.forward * step);
		} else {
			transform.Translate (-Vector3.forward * step);
		}
	}

	public void upgradeUnit() {
		level += 1;
		hp = hp_list[level];
		atk = atk_list [level];
		spd = spd_list [level];
		upgradeCost = upgrade_list[level];
		spawnCost = spawn_list[level];
		gold_production = gold_production_list[level];
	}
}
