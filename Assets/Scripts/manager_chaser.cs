using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_chaser : unit_manager {

	public manager_chaser() {
		hp_list = new List<int> { 1, 1, 1, 1, 1 };
		atk_list = new List<int> { 2, 4, 6, 8, 10 };
		spd_list = new List<float> { 1f, 1f, 1f, 1f, 1f };
		upgrade_list = new List<int> { 50, 80, 120, 150, 200 };
		spawn_list = new List<int> { 20, 40, 60, 80, 100 };
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
