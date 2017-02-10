using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour {

	public PlayerData.GameStates setGameState;
	// Use this for initialization
	void Start () {
		PlayerData.CurrentState = setGameState;
		switch (PlayerData.CurrentState)
		{
			case PlayerData.GameStates.LOADING:
				print("LOADING");
			break;

			case PlayerData.GameStates.STARTING:
				print("STARTING");
			break;
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
