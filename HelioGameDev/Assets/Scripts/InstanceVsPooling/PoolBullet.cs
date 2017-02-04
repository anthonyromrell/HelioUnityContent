using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PoolBullet : MonoBehaviour {

	bool canFire = true;
	public List<GameObject> bullets;	

	void Start () {
		BulletClass.SendBullet += AddBulletsToList;
		StartCoroutine(RecycleBullets());
	}
    private void AddBulletsToList(GameObject obj)
    {
        bullets.Add(obj);
		//obj.SetActive(false);
    }

	IEnumerator RecycleBullets () {
		yield return new WaitForEndOfFrame();
		while (canFire)
		{
			bullets[0].SetActive(true);
			bullets.RemoveAt(0);
			yield return new WaitForSeconds(1);
		}
	}
}
