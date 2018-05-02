using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
	public int hp;
	public int speed;
	public int atk;

	public Unit() {
		hp = 1;
		speed = 1;
		atk = 1;

	}

	public void subtractHP(int dmg) {
		hp -= dmg;
	}

	public int getAttack() {
		return atk;
	}

	public void calculateDamage(int damageTaken) {
		subtractHP (damageTaken);
		checkhp ();
	}

	public void checkhp() {
		if (hp <= 0) {
			Destroy (this.gameObject);
		}
	}
}
