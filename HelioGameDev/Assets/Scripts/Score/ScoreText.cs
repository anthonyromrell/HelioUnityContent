using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

	public Text scoreText;
	public int totalScore;

	void Start () {
		DragDot.UpdateScore += ChangeScore;
	}

	public void ChangeScore (int _i, string _s) {
		if(this.name == _s){
			totalScore += _i;
			scoreText.text = totalScore.ToString();
		}
	}
	
}
