using System;
using UnityEngine;

public class MyAction : MonoBehaviour {

	public static Action ThisAction;
	void Start () {
		ThisAction += InternalFunction;
	}

	void OnMouseDown () {
		if(ThisAction != null)
			ThisAction();
	}

	void InternalFunction () {
		print("Another function");
		ThisAction -= InternalFunction;
	}
}
