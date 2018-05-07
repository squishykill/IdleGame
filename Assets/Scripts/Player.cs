using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private int gold;
	private int goldGain;

	private manager_minion minion;
	private manager_runner runner;
	private manager_chaser chaser;
	private manager_tanker tanker;


	public int Gold {
		get {
			return gold;
		}
		set {
			gold = value;
		}
	}

	public int GoldGain {
		get {
			return goldGain;
		}
		set {
			goldGain = value;
		}
	}

	public Player() {
		Gold = 50;
		GoldGain = 1;
		minion = new manager_minion ();
		runner = new manager_runner ();
		chaser = new manager_chaser ();
		tanker = new manager_tanker ();
	}

	public void increaseGold() {
		if (Gold <= 500) {
			Gold += goldGain;
		}
	}

	public bool subtractGold(int unit) {
		int amt = 0;
		switch (unit) {
		case 0:
			amt = minion.getSpawnCost ();
			break;
		case 1:
			amt = runner.getSpawnCost ();
			break;
		case 2:
			amt = chaser.getSpawnCost ();
			break;
		case 3:
			amt = tanker.getSpawnCost ();
			break;
		}

		if (Gold >= amt) {
			Gold -= amt;
			return true;
		}
		return false;
	}

	public void updateLevel(int unit) {
		int cost = getUnitUpgradeCost (unit);
		if (Gold >= cost) {
			Gold -= cost;
			switch (unit) {
			case 0:
				minion.upgrade ();
				GoldGain += minion.getProductionCost ();
				break;
			case 1:
				runner.upgrade ();
				GoldGain += runner.getProductionCost ();
				break;
			case 2:
				chaser.upgrade ();
				GoldGain += chaser.getProductionCost ();
				break;
			case 3:
				tanker.upgrade ();
				GoldGain += tanker.getProductionCost ();
				break;
			}
		}
	}

	public int getUnitSpawnCost(int unit) {
		int value = 0;
		switch (unit) {
		case 0:
			value = minion.getSpawnCost ();
			break;
		case 1:
			value = runner.getSpawnCost ();
			break;
		case 2:
			value = chaser.getSpawnCost ();
			break;
		case 3:
			value = tanker.getSpawnCost ();
			break;
		}
		return value;
	}

	public int getUnitLevel(int unit) {
		int value = 0;
		switch (unit) {
		case 0:
			value = minion.getLevel ();
			break;
		case 1:
			value = runner.getLevel ();
			break;
		case 2:
			value = chaser.getLevel ();
			break;
		case 3:
			value = tanker.getLevel ();
			break;
		}
		return value;
	}

	public int getUnitUpgradeCost(int unit) {
		int value = 0;
		switch (unit) {
		case 0:
			value = minion.getUpgradeCost ();
			break;
		case 1:
			value = runner.getUpgradeCost ();
			break;
		case 2:
			value = chaser.getUpgradeCost ();
			break;
		case 3:
			value = tanker.getUpgradeCost ();
			break;
		}
		return value;
	}

	public int getGoldGain() {
		return GoldGain;
	}

	public int getHp(int unit) {
		int value = 0;
		switch (unit) {
		case 0:
			value = minion.getHp ();
			break;
		case 1:
			value = runner.getHp ();
			break;
		case 2:
			value = chaser.getHp ();
			break;
		case 3:
			value = tanker.getHp ();
			break;
		}
		return value;
	}

	public int getAtk(int unit) {
		int value = 0;
		switch (unit) {
		case 0:
			value = minion.getAtk ();
			break;
		case 1:
			value = runner.getAtk ();
			break;
		case 2:
			value = chaser.getAtk ();
			break;
		case 3:
			value = tanker.getAtk ();
			break;
		}
		return value;
	}

	public float getSpd(int unit) {
		float value = 0;
		switch (unit) {
		case 0:
			value = minion.getSpd ();
			break;
		case 1:
			value = runner.getSpd ();
			break;
		case 2:
			value = chaser.getSpd ();
			break;
		case 3:
			value = tanker.getSpd ();
			break;
		}
		return value;
	}
}
