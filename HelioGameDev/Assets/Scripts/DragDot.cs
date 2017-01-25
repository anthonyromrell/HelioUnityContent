using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDot : MonoBehaviour {

	Vector3 offset;
	string katsMeuw;

	void OnMouseDown () {
		offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		print(offset);
		katsMeuw = "Hello";
	}

	void OnMouseDrag () {
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
	}


}
