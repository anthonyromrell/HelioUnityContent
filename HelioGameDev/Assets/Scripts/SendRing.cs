using System;
using UnityEngine;

public class SendRing : MonoBehaviour {

	public static Action<GameObject, string, PowerUp> SendGO;

	public PowerUp myPowerUp;
	// Use this for initialization
	void Start () {
		if(SendGO != null)
			SendGO(gameObject, "Hello World", myPowerUp);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
