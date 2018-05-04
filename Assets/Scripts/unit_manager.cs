using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit_manager : MonoBehaviour {

	public List<int> upgrade_list;
	public List<int> spawn_list;
	public List<int> gold_production_list;

	public int upgradeCost;
	public int spawnCost;
	public int gold_production;
	public int level;

	// Use this for initialization

	public void upgrade() {
		level += 1;
		Debug.Log ("level:" + level);
		upgradeCost = upgrade_list [level];
		spawnCost = spawn_list [level];
		gold_production = gold_production_list [level];
	}

	public int getUpgradeCost() { 
		return upgradeCost;
	}

	public int getLevel() {
		return level;
	}

	public int getSpawnCost() {
		return spawnCost;
	}

	public int getProductionCost() {
		return gold_production;
	}


}
