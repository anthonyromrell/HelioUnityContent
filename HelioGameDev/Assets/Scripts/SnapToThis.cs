using UnityEngine;

public class SnapToThis : MonoBehaviour {

	
	void OnTriggerEnter () {
		StaticVars.newPosition = transform.position;
		
	}

	void OnTriggerStay(Collider other)
	{
		print("trigger");
		if(!StaticVars.dragging) {
			print("false");
			GetComponent<BoxCollider>().enabled = false;
		}
	}

}
