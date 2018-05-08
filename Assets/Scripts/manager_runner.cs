using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_runner : unit_manager {

	public manager_runner() {
		hp_list = new List<int> { 1, 1, 2, 2, 3 };
		atk_list = new List<int> { 1, 2, 3, 4, 6 };
		spd_list = new List<float> { 1.4f, 1.5f, 1.6f, 1.7f, 1.8f };
		upgrade_list = new List<int> { 30, 60, 100, 140, 180 };
		spawn_list = new List<int> { 10, 20, 30, 40, 50 };
		gold_production_list = new List<int> { 0, 2, 3, 4, 5 };

		level = 0;
		hp = hp_list [level];
		atk = atk_list [level];
		spd = spd_list [level];
		upgradeCost = upgrade_list [level];
		spawnCost = spawn_list [level];
		gold_production = gold_production_list [level];
	}
}
