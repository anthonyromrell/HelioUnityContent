using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDot : MonoBehaviour {

	Vector3 offset;

	
	void OnMouseDown () {
		offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		StaticVars.dragging = true;
	}

	void OnMouseDrag () {
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
	}


	void OnMouseUp()
	{
		StaticVars.dragging = false;
		transform.position = StaticVars.newPosition;
		Invoke("StopDrag", 0.1f);
	}

	void StopDrag () {
		GetComponent<SphereCollider>().enabled = false;
	}

}
