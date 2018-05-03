using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour {
	public int level;
	public int hp;
	public int atk;
	public float spd;
	public int upgradeCost;
	public int spawnCost;
	public int gold_production;
	public int player;
	public Text hp_display;
	public float step;

	public Unit() {
		level = 0;
		hp = 1;
		atk = 1;
		spd = 1f;
		upgradeCost = 1;
		spawnCost = 1;
		gold_production = 1;
	}

	void Awake() {
		hp_display.text = hp.ToString ();
	}

	public void subtractHP(int dmg) {
		hp -= dmg;
	}

	public int getAttack() {
		return atk;
	}

	public void calculateDamage(int damageTaken) {
		subtractHP (damageTaken);
		hp_display.text = hp.ToString ();
		checkhp ();
	}

	public void checkhp() {
		if (hp <= 0) {
			Destroy (this.gameObject);
		}
	}

	public void setPlayer(int num) {
		player = num;
	}
}
