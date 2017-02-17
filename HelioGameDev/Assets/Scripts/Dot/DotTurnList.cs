using System.Collections.Generic;
using UnityEngine;

public class DotTurnList : MonoBehaviour {

	public List<DragDot> avaliableDots;
	public ColorState.Colors color;

	int i = 0;
	void Start () {
		DragDot.StartNewTurn += NextTurn;
		NextTurn();
	}

	void NextTurn () {
		Invoke("RunLate", 0.1f);
	}

	void RunLate () {
		if(color == ColorState.currentPlayer) {
			print(ColorState.currentPlayer);
			avaliableDots[i].transform.position = transform.position;
			i++;
		}
	}
}
