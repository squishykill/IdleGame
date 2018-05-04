using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_tanker : unit_manager {

	public manager_tanker() {
		upgrade_list = new List<int> { 100, 150, 200, 250, 300 };
		spawn_list = new List<int> { 100, 120, 150, 180, 200 };
		gold_production_list = new List<int> { 4, 5, 6, 7, 8 };

		level = 0;
		upgradeCost = upgrade_list [level];
		spawnCost = spawn_list [level];
		gold_production = gold_production_list [level];
	}
}
