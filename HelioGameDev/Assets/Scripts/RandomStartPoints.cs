using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStartPoints : MonoBehaviour {

	public Transform[] startPoints;
	void Start () {
		transform.position = startPoints[Random.Range(0,startPoints.Length-1)].position;
	}
}
