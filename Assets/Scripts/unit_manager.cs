using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit_manager : MonoBehaviour {

	public List<int> hp_list;
	public List<int> atk_list;
	public List<float> spd_list;
	public List<int> upgrade_list;
	public List<int> spawn_list;
	public List<int> gold_production_list;

	public int hp;
	public int atk;
	public float spd;
	public int upgradeCost;
	public int spawnCost;
	public int gold_production;
	public int level;

	// Use this for initialization

	public void upgrade() {
		level += 1;
		hp = hp_list [level];
		atk = atk_list [level];
		spd = spd_list [level];
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

	public int getHp() {
		return hp;
	}

	public int getAtk() {
		return atk;
	}

	public float getSpd() {
		return spd;
	}


}
