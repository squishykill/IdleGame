using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

	private int gold;
	private int goldGain;

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
		Gold = 0;
		GoldGain = 1;
	}

	public void increaseGold() {
		Gold += goldGain;
	}

	public void subtractGold(int amt) {
		Gold -= amt;
	}
}
