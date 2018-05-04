using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_chaser : unit_manager {

	public manager_chaser() {
		hp_list = new List<int> { 2, 4,6, 8, 12 };
		atk_list = new List<int> { 2, 4, 6, 8, 10 };
		spd_list = new List<float> { 0.8f, 0.8f, 0.8f, 0.8f, 0.8f };
		upgrade_list = new List<int> { 30, 60, 120, 240, 480 };
		spawn_list = new List<int> { 15, 20, 25, 30, 35 };
		gold_production_list = new List<int> { 2, 3, 4, 5, 6 };

		level = 0;
		hp = hp_list [level];
		atk = atk_list [level];
		spd = spd_list [level];
		upgradeCost = upgrade_list [level];
		spawnCost = spawn_list [level];
		gold_production = gold_production_list [level];
	}
}
