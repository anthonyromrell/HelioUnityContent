using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDot : MonoBehaviour {

	//Need a mouse event to start Dragging
	Vector3 offset;
	void OnMouseDown () {
		offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
		print(offset);
	}
	//Funciton to drag
	void OnMouseDrag () {
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
	}

	//Will drag using mouse Position

}
