using UnityEngine;

public class ReturnWeapon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerGetsWeapon.GetWeapon += ReturnThisWeapon;
	}
	
	// Update is called once per frame
	string ReturnThisWeapon () {
		return "Club";
	}
}
