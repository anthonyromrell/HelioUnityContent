using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

	public Text scoreText;
	public int totalScore;

	public PlayerTurn.Players textName;

	void Start () {
		DragDot.UpdateScore += ChangeScore;
	}

	public void ChangeScore (int _i, PlayerTurn.Players _s) {
		if(textName == _s){
			totalScore += _i;
			scoreText.text = totalScore.ToString();
		}
	}
	
}
