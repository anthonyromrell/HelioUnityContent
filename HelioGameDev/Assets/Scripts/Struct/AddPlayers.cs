using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayers : MonoBehaviour {

	public PlayerData player1 = new PlayerData();

	// Use this for initialization
	void Start () {
		print(player1.health);
		player1.speed = 20;
		print(player1.speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
