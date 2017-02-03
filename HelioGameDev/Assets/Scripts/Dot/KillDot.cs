using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDot : MonoBehaviour {

	void Start () {
		Invoke("Kill", 5);
		
	}
	
	void Kill () {
		Object.Destroy(gameObject);
	}

	void OnCollisionEnter(Collision other)
	{
		Kill();
	}
}
