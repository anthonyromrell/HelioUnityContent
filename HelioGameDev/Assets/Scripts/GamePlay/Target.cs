using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	//public Material thisMat;
	public Renderer thisMat;
	void OnTriggerEnter (Collider _obj) {
		print(_obj.GetComponent<Renderer>().material);	
		print(thisMat);

		Renderer _objMat = _obj.GetComponent<Renderer>();
		
		if (_objMat.material == thisMat.material)
		{
			print("Add Points");
		} else {
			print("Game Over");
		}
	}
	//if ring is colored RED

	//add points

	//else end game
	
}
