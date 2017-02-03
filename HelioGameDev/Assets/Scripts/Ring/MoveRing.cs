using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveRing : MonoBehaviour {

	// Needs NavMeshAgent for Movement
	public NavMeshAgent agent;
	// Need a target gameObject as a destination
	public Transform destination;

	//this gets a local component for us
	void Start() {
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Set the NaveMeshAgent destination to the target
	void Update () {
		agent.destination = destination.position;
	}
}
