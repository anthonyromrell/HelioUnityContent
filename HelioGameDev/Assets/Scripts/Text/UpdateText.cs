using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour {

	private Text text;
	private int score;
	public ColorState.Colors colorChoice;

	void Start () {
		text = GetComponent<Text>();
		DragDot.UpdateScore += ChangeText;
		TurnControl.SendCurrentPlayer += ChangeText;
		MatchObject.SendWinner += ChangeText;
	}
	public void ChangeText (DragDot _dot) {
		if(colorChoice == _dot.dotColor){
			score += _dot.dotValue;
			text.text = score.ToString();
		}
	}

	public void ChangeText (string _text, ColorState.Colors _dot) {
		if(colorChoice == ColorState.Colors.NO){
			text.text = _text;
		}
	}
}