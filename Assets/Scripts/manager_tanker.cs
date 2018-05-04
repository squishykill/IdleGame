using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_tanker : unit_manager {

	public manager_tanker() {
		hp_list = new List<int> { 5, 8, 12, 15, 25 };
		atk_list = new List<int> { 5, 10, 15, 18, 20 };
		spd_list = new List<float> { 0.5f, 0.5f, 0.5f, 0.5f, 0.5f };
		upgrade_list = new List<int> { 50, 100, 200, 400, 800 };
		spawn_list = new List<int> { 100, 125, 150, 175, 200 };
		gold_production_list = new List<int> { 3, 4, 5, 6, 7 };

		level = 0;
		hp = hp_list [level];
		atk = atk_list [level];
		spd = spd_list [level];
		upgradeCost = upgrade_list [level];
		spawnCost = spawn_list [level];
		gold_production = gold_production_list [level];
	}
}
