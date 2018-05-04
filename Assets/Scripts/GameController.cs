using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private Player p1;
	private Player p2;

	public Text p1_gold;
	public Text p2_gold;
	public Text p1_goldGain;
	public Text p2_goldGain;

	public Text p1_minionLevel;
	public Text p1_minionUpgradeCost;

	public Text p1_runnerLevel;
	public Text p1_runnerUpgradeCost;

	public Text p1_chaserLevel;
	public Text p1_chaserUpgradeCost;

	public Text p1_tankerLevel;
	public Text p1_tankerUpgradeCost;

	public Text p2_minionLevel;
	public Text p2_minionUpgradeCost;

	public Text p2_runnerLevel;
	public Text p2_runnerUpgradeCost;

	public Text p2_chaserLevel;
	public Text p2_chaserUpgradeCost;

	public Text p2_tankerLevel;
	public Text p2_tankerUpgradeCost;

	private float nextUpdate = 1;

	// Use this for initialization
	void Start () {
		p1 = new Player ();
		p2 = new Player ();
		displayInfo ();
	}
	
	// Update is called once per frame
	void Update () {
		//update gold every second
		if (Time.time >= nextUpdate) {
			nextUpdate = Mathf.FloorToInt (Time.time) + 1;
			updateGold ();
		}
	}

	public void displayGold() {
		p1_gold.text = p1.Gold.ToString ();
		p2_gold.text = p2.Gold.ToString ();
		p1_goldGain.text = "+" + p1.GoldGain.ToString ();
		p2_goldGain.text = "+" + p2.GoldGain.ToString ();
	}

	public void updateGold() {
		p1.increaseGold ();
		p2.increaseGold ();
		displayGold ();
	}

	//only for summoning unit
	public bool spawnUnit(int player, int unit) {
		if (player == 1) {
			if (p1.subtractGold (unit)) {
				displayGold ();
				return true;
			} else {
				return false;
			}
		} else {
			if (p2.subtractGold (unit)) {
				displayGold ();
				return true;
			} else {
				return false;
			}
		}
	}

	//upgrading unit -check unit cost- check gold- upgrade
	public void upgradeUnitLevelA(int unit) {
		if (p1.getUnitLevel (unit) != 4) {
			
			p1.updateLevel (unit);
			switch (unit) {
			case 0:
				p1_minionLevel.text = "Lv " + p1.getUnitLevel (unit).ToString () + " | " + p1.getUnitSpawnCost (unit).ToString () + "g";
				p1_minionUpgradeCost.text = p1.getUnitUpgradeCost (unit).ToString ();
				p1_goldGain.text = "+" + p1.getGoldGain ().ToString ();
				break;
			case 1:
				p1_runnerLevel.text = "Lv " + p1.getUnitLevel (unit).ToString () + " | " + p1.getUnitSpawnCost (unit).ToString () + "g";
				p1_runnerUpgradeCost.text = p1.getUnitUpgradeCost (unit).ToString ();
				p1_goldGain.text = "+" + p1.getGoldGain ().ToString ();
				break;
			case 2:
				p1_chaserLevel.text = "Lv " + p1.getUnitLevel (unit).ToString () + " | " + p1.getUnitSpawnCost (unit).ToString () + "g";
				p1_chaserUpgradeCost.text = p1.getUnitUpgradeCost (unit).ToString ();
				p1_goldGain.text = "+" + p1.getGoldGain ().ToString ();
				break;
			case 3:
				p1_tankerLevel.text = "Lv " + p1.getUnitLevel (unit).ToString () + " | " + p1.getUnitSpawnCost (unit).ToString () + "g";
				p1_tankerUpgradeCost.text = p1.getUnitUpgradeCost (unit).ToString ();
				p1_goldGain.text = "+" + p1.getGoldGain ().ToString ();
				break;
			}
		} else {
			switch (unit) {
			case 0:
				p1_minionUpgradeCost.text = "Max";
				break;
			case 1:
				p1_runnerUpgradeCost.text = "Max";
				break;
			case 2:
				p1_chaserUpgradeCost.text = "Max";
				break;
			case 3:
				p1_tankerUpgradeCost.text = "Max";
				break;
			}
		}
	}

	public void upgradeUnitLevelB(int unit) {
		if (p2.getUnitLevel (unit) != 4) {
			p2.updateLevel (unit);

			switch (unit) {
			case 0:
				if (p2.getUnitLevel (unit) <= 4) {
					p2_minionLevel.text = "Lv " + p2.getUnitLevel (unit).ToString () + " | " + p2.getUnitSpawnCost (unit).ToString () + "g";
					p2_minionUpgradeCost.text = p2.getUnitUpgradeCost (unit).ToString ();
					p2_goldGain.text = "+" + p2.getGoldGain ().ToString ();
				}
				break;
			case 1:
				if (p2.getUnitLevel (unit) <= 4) {
					p2_runnerLevel.text = "Lv " + p2.getUnitLevel (unit).ToString () + " | " + p2.getUnitSpawnCost (unit).ToString () + "g";
					p2_runnerUpgradeCost.text = p2.getUnitUpgradeCost (unit).ToString ();
					p2_goldGain.text = "+" + p2.getGoldGain ().ToString ();
				}
				break;

			case 2:
				if (p2.getUnitLevel (unit) <= 4) {
					p2_chaserLevel.text = "Lv " + p2.getUnitLevel (unit).ToString () + " | " + p2.getUnitSpawnCost (unit).ToString () + "g";
					p2_chaserUpgradeCost.text = p1.getUnitUpgradeCost (unit).ToString ();
					p2_goldGain.text = "+" + p2.getGoldGain ().ToString ();
				}
				break;
			case 3:
				if (p2.getUnitLevel (unit) <= 4) {
					p2_tankerLevel.text = "Lv " + p2.getUnitLevel (unit).ToString () + " | " + p2.getUnitSpawnCost (unit).ToString () + "g";
					p2_tankerUpgradeCost.text = p2.getUnitUpgradeCost (unit).ToString ();
					p2_goldGain.text = "+" + p2.getGoldGain ().ToString ();
				}
				break;
			}
		} else {
			switch (unit) {
			case 0:
				p2_minionUpgradeCost.text = "Max";
				break;
			case 1:
				p2_runnerUpgradeCost.text = "Max";
				break;
			case 2:
				p2_chaserUpgradeCost.text = "Max";
				break;
			case 3:
				p2_tankerUpgradeCost.text = "Max";
				break;
			}
		}
	}

	public void displayInfo() {
		p1_minionLevel.text = "Lv " + p1.getUnitLevel (0).ToString () + " | " + p1.getUnitSpawnCost (0).ToString() + "g";
		p1_minionUpgradeCost.text = p1.getUnitUpgradeCost (0).ToString();

		p1_runnerLevel.text = "Lv " + p1.getUnitLevel (1).ToString () + " | " + p1.getUnitSpawnCost (1).ToString() + "g";
		p1_runnerUpgradeCost.text = p1.getUnitUpgradeCost (1).ToString();

		p1_chaserLevel.text = "Lv " + p1.getUnitLevel (2).ToString () + " | " + p1.getUnitSpawnCost (2).ToString() + "g";
		p1_chaserUpgradeCost.text = p1.getUnitUpgradeCost (2).ToString();

		p1_tankerLevel.text = "Lv " + p1.getUnitLevel (3).ToString () + " | " + p1.getUnitSpawnCost (3).ToString() + "g";
		p1_tankerUpgradeCost.text = p1.getUnitUpgradeCost (3).ToString();

		p2_minionLevel.text = "Lv " + p2.getUnitLevel (0).ToString () + " | " + p2.getUnitSpawnCost (0).ToString() + "g";
		p2_minionUpgradeCost.text = p1.getUnitUpgradeCost (0).ToString();

		p2_runnerLevel.text = "Lv " + p2.getUnitLevel (1).ToString () + " | " + p2.getUnitSpawnCost (1).ToString() + "g";
		p2_runnerUpgradeCost.text = p1.getUnitUpgradeCost (1).ToString();

		p2_chaserLevel.text = "Lv " + p2.getUnitLevel (2).ToString () + " | " + p2.getUnitSpawnCost (2).ToString() + "g";
		p2_chaserUpgradeCost.text = p1.getUnitUpgradeCost (2).ToString();

		p2_tankerLevel.text = "Lv " + p2.getUnitLevel (3).ToString () + " | " + p2.getUnitSpawnCost (3).ToString() + "g";
		p2_tankerUpgradeCost.text = p2.getUnitUpgradeCost (3).ToString();
	}


	public int getUnitLevel(int player, int unit) {
		if (player == 1) {
			return p1.getUnitLevel (unit);
		} else {
			return p2.getUnitLevel (unit);
		}
	}

	public int getUnitHp(int player, int unit) {
		if (player == 1) {
			return p1.getHp (unit);
		} else {
			return p2.getHp (unit);
		}
	}

	public int getUnitAtk(int player, int unit) {
		if (player == 1) {
			return p1.getAtk (unit);
		} else {
			return p2.getAtk (unit);
		}
	}

	public float getUnitSpd(int player, int unit) {
		if (player == 1) {
			return p1.getSpd (unit);
		} else {
			return p2.getSpd (unit);
		}
	}

}
