using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_tanker : unit_manager {

	public manager_tanker() {
		hp_list = new List<int> { 5, 7, 9, 11, 15 };
		atk_list = new List<int> { 5, 10, 15, 18, 20 };
		spd_list = new List<float> { 0.5f, 0.5f, 0.5f, 0.5f, 0.5f };
		upgrade_list = new List<int> { 100, 150, 200, 250, 300 };
		spawn_list = new List<int> { 50, 75, 100, 150, 200 };
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
