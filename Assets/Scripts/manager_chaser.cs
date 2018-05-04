using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_chaser : unit_manager {

	public manager_chaser() {
		upgrade_list = new List<int> { 40, 60, 80, 160, 200 };
		spawn_list = new List<int> { 5, 10, 15, 20, 25 };
		gold_production_list = new List<int> { 1, 2, 3, 4, 5 };

		level = 0;
		upgradeCost = upgrade_list [level];
		spawnCost = spawn_list [level];
		gold_production = gold_production_list [level];
	}
}
