using UnityEngine;
using System;

public class SnapToThis : MonoBehaviour {

	public static Action<Vector3> SendPosition;
	void OnTriggerEnter () {
		if(SendPosition != null)
			SendPosition(transform.position);
	}
}
