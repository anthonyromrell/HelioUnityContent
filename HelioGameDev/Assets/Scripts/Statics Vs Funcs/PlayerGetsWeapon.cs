using UnityEngine;
using System;

public class PlayerGetsWeapon : MonoBehaviour {

	public static Func<string> GetWeapon;
	public string myWeapon;
	// Use this for initialization
	void Start () {
		myWeapon = GetWeapon();
	}
}
