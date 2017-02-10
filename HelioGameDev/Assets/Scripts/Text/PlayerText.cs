using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerText : MonoBehaviour {

	public Text playerText;

	// Use this for initialization
	void Start () {
		playerText = GetComponent<Text>();
		TurnControl.SendCurrentPlayer += DisplayPlayer;
		MatchObject.SendWinner += DisplayWinner;
	}

    private void DisplayWinner()
    {
        playerText.text = $"{PlayerTurn.currentPlayer} Is the Winner.";
    }

    private void DisplayPlayer(PlayerTurn.Players obj)
    {
        playerText.text = $"The current player is {obj}.";
    }
}
