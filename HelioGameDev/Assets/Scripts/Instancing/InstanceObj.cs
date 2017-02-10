using UnityEngine;

public class InstanceObj : MonoBehaviour {

	public GameObject cube;
	public Vector3 pos;
	// Use this for initialization
	void Start () {
		Instantiate(cube, pos, Quaternion.identity);
	}
	
}
