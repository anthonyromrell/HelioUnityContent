using UnityEngine;
using System.Collections;

public class BulletInstance : MonoBehaviour {

	public GameObject bullet;
	private GameObject newBullet;
	// Use this for initialization
	void Start () {
		StartCoroutine(InstanceBullet());
	}
	
	IEnumerator InstanceBullet () {
		newBullet = Instantiate(bullet);
		newBullet.transform.parent = transform;
		yield return new WaitForSeconds(0.25f);
		Start();
	}
}
