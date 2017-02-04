using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	public virtual void Start () {
		Walk();
		Sleep();
	}
	
	void Sleep () {
		print("Sleep");
	}

	public virtual void Walk () {
		print("Walk on four legs");
	}

}
