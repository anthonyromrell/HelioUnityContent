using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendRingHandler : MonoBehaviour {

	public GameObject ring;

	void Start () {
		SendRing.SendGO += HandleSendRing;
	}
	
	void HandleSendRing (GameObject _go, string _s, PowerUp _p) {
		ring = _go;
		gameObject.name = _s;
		print(_p.Time*3);
		print(_p.Power);
	}
}
