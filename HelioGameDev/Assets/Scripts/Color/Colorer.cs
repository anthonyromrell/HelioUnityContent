using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorer : MonoBehaviour {

	void OnTriggerEnter (Collider _obj) {
		if(_obj.tag == "Draggable") {
			GetComponent<Renderer>().material = 
				_obj.GetComponent<Renderer>().material;
		}
	}

	//Compare the ring material to the the dot's material
	//if = then change rings material to the dot's material
	
}
