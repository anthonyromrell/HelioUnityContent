using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotController : MonoBehaviour {
	
	public GameObject myGO;


	// Use this for initialization
	void Start () {
		for(int i=0; i < 10; i++) {
			Instantiate(myGO);
		}
	}
	
	
}
