using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_minion : unit_manager {

	public manager_minion() {
		hp_list = new List<int> { 1, 2, 3, 4, 5 };
		atk_list = new List<int> { 1, 2, 3, 4, 5 };
		spd_list = new List<float> { 1f, 1f, 1f, 1f, 1f };
		upgrade_list = new List<int> { 10, 20, 40, 80, 160 };
		spawn_list = new List<int> { 2, 4, 10, 15, 20 };
		gold_production_list = new List<int> { 0, 1, 2, 3, 3 };

		level = 0;
		hp = hp_list [level];
		atk = atk_list [level];
		spd = spd_list [level];
		upgradeCost = upgrade_list [level];
		spawnCost = spawn_list [level];
		gold_production = gold_production_list [level];
	}

}
