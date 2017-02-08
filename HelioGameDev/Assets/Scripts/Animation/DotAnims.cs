using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DotAnims : MonoBehaviour {

	private Animator anims;

	// Use this for initialization
	void Start () {
		anims = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void OnMouseUp () {
		anims.SetBool("MouseUp", true);
		anims.SetBool("Drag", false);
	}

	void OnMouseDown()
	{
		anims.SetBool("Drag", true);
	}

	public void EndAnim () {
		anims.SetBool("MouseUp", false);
	}

	public void StartDrag () {
		anims.SetBool("Drag", false);
	}
}
