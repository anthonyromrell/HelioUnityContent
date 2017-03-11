using System;
using UnityEngine;


public class AutoMove : MonoBehaviour {

	public static Action<float> Move;
	public static Action<float> Rotate;
	public float speed = 3;
	// Update is called once per frame
	void Update () {

		if (Rotate != null)
		{
			Rotate(UnityEngine.Random.Range(-10, 10));
		}

		if (Move != null)
		{
			Move(speed);
		}
	}
}
