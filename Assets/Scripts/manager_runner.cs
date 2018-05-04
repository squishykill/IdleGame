using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_runner : unit_manager {

	public manager_runner() {
		upgrade_list = new List<int> { 40, 70, 120, 180, 200 };
		spawn_list = new List<int> { 20, 40, 60, 80, 100 };
		gold_production_list = new List<int> { 2, 3, 4, 5, 6 };

		level = 0;
		upgradeCost = upgrade_list [level];
		spawnCost = spawn_list [level];
		gold_production = gold_production_list [level];
	}
}
