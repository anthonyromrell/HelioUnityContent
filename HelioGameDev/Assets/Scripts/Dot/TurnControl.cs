using System;
using UnityEngine;

public class TurnControl : MonoBehaviour {

	public static Action<PlayerTurn.Players> SendCurrentPlayer;
	void Start () {
		SendCurrentPlayer(PlayerTurn.currentPlayer);
	}

	void OnEnable()
	{
		DragDot.StartNewTurn += Start;
	}
	
}
