using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DotAnims : MonoBehaviour {

	private Animator anims;

	void Start () {
		anims = GetComponent<Animator>();
	}
	void OnMouseDown()
	{
		anims.SetBool("Drag", true);
	}

	void OnMouseUp () {
		anims.SetBool("MouseUp", true);
	}	

	void Off (string _name) {
		anims.SetBool(_name, false);
	}
}
