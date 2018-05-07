using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Summon_Check : MonoBehaviour {

	public Button p1_minion;
	public Button p1_runner;
	public Button p1_chaser;
	public Button p1_tanker;

	public Button p2_minion;
	public Button p2_runner;
	public Button p2_chaser;
	public Button p2_tanker;

	public Button p1_minion_upgrade;
	public Button p1_runner_upgrade;
	public Button p1_chaser_upgrade;
	public Button p1_tanker_upgrade;

	public Button p2_minion_upgrade;
	public Button p2_runner_upgrade;
	public Button p2_chaser_upgrade;
	public Button p2_tanker_upgrade;

	public int p1_gold;
	public int p2_gold;

	public GameController gc;


	// Use this for initialization
	void Start () {
		gc = GetComponent<GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		p1_gold = gc.getGold (1);
		p2_gold = gc.getGold (2);

		//spawn cost check
		if (gc.getUnitSpawnCost (1, 0) <= p1_gold) {
			p1_minion.interactable = true;
		} else {
			p1_minion.interactable = false;
		}
		if (gc.getUnitSpawnCost (1, 1) <= p1_gold) {
			p1_runner.interactable = true;
		} else {
			p1_runner.interactable = false;
		}
		if (gc.getUnitSpawnCost (1, 2) <= p1_gold) {
			p1_chaser.interactable = true;
		} else {
			p1_chaser.interactable = false;
		}
		if (gc.getUnitSpawnCost (1, 3) <= p1_gold) {
			p1_tanker.interactable = true;
		} else {
			p1_tanker.interactable = false;
		}
			
		if (gc.getUnitSpawnCost (2, 0) <= p2_gold) {
			p2_minion.interactable = true;
		} else {
			p2_minion.interactable = false;
		}
		if (gc.getUnitSpawnCost (2, 1) <= p2_gold) {
			p2_runner.interactable = true;
		} else {
			p2_runner.interactable = false;
		}
		if (gc.getUnitSpawnCost (2, 2) < p2_gold) {
			p2_chaser.interactable = true;
		} else {
			p2_chaser.interactable = false;
		}
		if (gc.getUnitSpawnCost (2, 3) <= p2_gold) {
			p2_tanker.interactable = true;
		} else {
			p2_tanker.interactable = false;
		}

		//upgrade cost check
		if (gc.getUnitUpgradeCost (1, 0) <= p1_gold) {
			p1_minion_upgrade.interactable = true;
		} else {
			p1_minion_upgrade.interactable = false;
		}
		if (gc.getUnitUpgradeCost (1, 1) <= p1_gold) {
			p1_runner_upgrade.interactable = true;
		} else {
			p1_runner_upgrade.interactable = false;
		}
		if (gc.getUnitUpgradeCost (1, 2) < p1_gold) {
			p1_chaser_upgrade.interactable = true;
		} else {
			p1_chaser_upgrade.interactable = false;
		}
		if (gc.getUnitUpgradeCost (1, 3) < p1_gold) {
			p1_tanker_upgrade.interactable = true;
		} else {
			p1_tanker_upgrade.interactable = false;
		}

		if (gc.getUnitUpgradeCost (2, 0) <= p2_gold) {
			p2_minion_upgrade.interactable = true;
		} else {
			p2_minion_upgrade.interactable = false;
		}
		if (gc.getUnitUpgradeCost (2, 1) <= p2_gold) {
			p2_runner_upgrade.interactable = true;
		} else {
			p2_runner_upgrade.interactable = false;
		}
		if (gc.getUnitUpgradeCost (2, 2) < p2_gold) {
			p2_chaser_upgrade.interactable = true;
		} else {
			p2_chaser_upgrade.interactable = false;
		}
		if (gc.getUnitUpgradeCost (2, 3) <= p2_gold) {
			p2_tanker_upgrade.interactable = true;
		} else {
			p2_tanker_upgrade.interactable = false;
		}

	}
}
