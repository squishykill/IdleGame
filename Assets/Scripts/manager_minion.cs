﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_minion : unit_manager {

	public manager_minion() {
		upgrade_list = new List<int> { 20, 40, 80, 120, 150 };
		spawn_list = new List<int> { 5, 10, 15, 20, 25 };
		gold_production_list = new List<int> { 1, 2, 3, 4, 5 };

		level = 0;
		upgradeCost = upgrade_list [level];
		spawnCost = spawn_list [level];
		gold_production = gold_production_list [level];
	}

}