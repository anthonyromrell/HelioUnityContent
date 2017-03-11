using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

	private CharacterController controller;
	private Vector3 tempPosition;
	public float speed = 5;
	void Start () {
		controller = GetComponent<CharacterController>();
	}

	void Update () {
		tempPosition.z = speed*Input.GetAxis("Vertical")*Time.deltaTime;
		tempPosition.x = speed*Input.GetAxis("Horizontal")*Time.deltaTime;
		controller.Move(tempPosition);
	}
}
