using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunctions : MonoBehaviour {

	public int myPower;
	public int firePower;
	public int speedPower;
	public GameObject one;
	public GameObject two;

	int Power (int _i, int _j) {
		return _i+_j;
	}
	void NewPower (int _i, int _j) {
		myPower = _i+_j;
	} 

	GameObject SendObj (string _s, GameObject _go) {
		_go.name = _s;
		return _go;	
	}

	void Start () {
		myPower = Power(12, 6);
		firePower = Power(12, 10);
		speedPower = Power(9, 9);
		NewPower(3,100);
		two = SendObj("New", one);
	}
}
