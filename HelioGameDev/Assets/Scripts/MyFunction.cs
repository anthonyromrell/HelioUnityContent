using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFunction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MyAction.ThisAction += ThisFunction;
	}
	
	void ThisFunction () {
		print("Function Called");
	}
}
