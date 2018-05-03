using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	Player p1;
	Player p2;

	public Text p1_gold;
	public Text p2_gold;

	private int nextUpdate = 1;

	// Use this for initialization
	void Start () {
		p1 = new Player ();
		p2 = new Player ();
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
	}

	public void updateGold() {
		p1.increaseGold ();
		p2.increaseGold ();
		displayGold ();
	}

	public void increaseGoldGain(int player, int gain) {
		if (player == 1) {
			p1.GoldGain += gain;
		} else {
			p2.GoldGain += gain;
		}
	}

	public void spendGold(int player, int amt) {
		if (player == 1) {
			p1.subtractGold (amt);
		} else {
			p2.subtractGold (amt);
		}
	}
}
