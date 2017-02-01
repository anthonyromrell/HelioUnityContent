using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour {

	void MyFunction (ref int _i) {
		_i+=_i;
	}

	void MyFunction (int _i) {
		_i = _i*_i;
		print(_i);
	}

	void MyFunction (string _s) {
		print(_s);
	}

	void MyFunction (float _f) {
		_f -= _f;
		print(_f);
	} 

	void Start () {
		MyFunction("Hello There");
		MyFunction(8.5f);
		int myInt = 8;
		MyFunction(myInt);
		print(myInt);
		MyFunction(ref myInt);
		print(myInt);
	}

}
