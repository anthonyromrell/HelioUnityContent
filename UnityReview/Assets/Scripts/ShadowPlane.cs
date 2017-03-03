using UnityEngine;

public class ShadowPlane : MonoBehaviour {

	public Transform player;
	Vector3	reverseRotate;
	Quaternion revRot;

	// Update is called once per frame
	void Update () {
		//revRot.y = player.rotation.y*-1;
		//transform.rotation = revRot;

		reverseRotate.y = player.rotation.eulerAngles.y*-1;
		transform.rotation = Quaternion.Euler(reverseRotate); 
	}
}
