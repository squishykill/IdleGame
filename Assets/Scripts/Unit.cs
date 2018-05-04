using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour {
	public int level;
	public int hp;
	public int atk;
	public float spd;
	public int player;
	public Text hp_display;
	public float step;

	public Unit() {
		level = 0;
	}

	public void subtractHP(int dmg) {
		hp -= dmg;
	}

	public int getAttack() {
		return atk;
	}

	//update hp on unit
	public void updateDisplay() {
		hp_display.text = hp.ToString ();

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

	//set player for movement
	public void setPlayer(int num) {
		player = num;
	}

	public void setStats(int level_value, int hp_value, int atk_value, float spd_value, int player_value) {
		level = level_value;
		hp = hp_value;
		atk = atk_value;
		spd = spd_value;
		player = player_value;
		updateDisplay ();
	}
}
