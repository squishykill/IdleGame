using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_chaser : unit_manager {

	public manager_chaser() {
		hp_list = new List<int> { 1, 1, 1, 1, 1 };
		atk_list = new List<int> { 2, 4, 6, 8, 10 };
		spd_list = new List<float> { 1f, 1f, 1f, 1f, 1f };
		upgrade_list = new List<int> { 50, 100, 150, 200, 300 };
		spawn_list = new List<int> { 60, 80, 110, 130, 150 };
		gold_production_list = new List<int> { 0, 2, 2, 2, 2 };

		level = 0;
		hp = hp_list [level];
		atk = atk_list [level];
		spd = spd_list [level];
		upgradeCost = upgrade_list [level];
		spawnCost = spawn_list [level];
		gold_production = gold_production_list [level];
	}
}
