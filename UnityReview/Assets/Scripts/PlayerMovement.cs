using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour {

	Vector3 moveDirection;
	public float moveSpeed = 5;
	public float roateSpeed = 5;
	CharacterController contoller;

	void Start () {
		contoller = GetComponent<CharacterController> ();
		MoveUsingArrowKeys.MoveOnArrows += Move;
		MoveUsingArrowKeys.RotateOnArrows += Rotate;
	}

	// void OnTriggerEnter(Collider other)
	// {
	// 	AutoMove.Move += Move;
	// 	AutoMove.Rotate += Rotate;
	// 	MoveUsingArrowKeys.MoveOnArrows -= Move;
	// 	Invoke("ReturnMove", 5);
	// }

	// void ReturnMove () {
	// 	AutoMove.Move -= Move;
	// 	AutoMove.Rotate -= Rotate;
	// 	MoveUsingArrowKeys.MoveOnArrows += Move;
	// }
	void Rotate (float _rotateInY)
	{
		transform.Rotate (0, _rotateInY*roateSpeed, 0);
	}

	void Move (float _moveInZ) {
		moveDirection.z = _moveInZ;
		moveDirection = transform.TransformDirection (moveDirection*moveSpeed*Time.deltaTime);
		contoller.Move (moveDirection);
	}
}
