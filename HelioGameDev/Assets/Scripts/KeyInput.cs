using System;
using UnityEngine;

public class KeyInput : MonoBehaviour {

	Action PlayerInput;
	void Start () {
		PlayerInput = MyInput;
		Invoke("EndTime", 5);
	}
	
	void EndTime () {
		PlayerInput = null;
		print("Time is Up");
	}

	void Update () {
		if(PlayerInput != null)
			PlayerInput();
	}

	void MyInput () {
		if(Input.GetKey(KeyCode.A)) {
			print("You can Play");
		}
	}
}
