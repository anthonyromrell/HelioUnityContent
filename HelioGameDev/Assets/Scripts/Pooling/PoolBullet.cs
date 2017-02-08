using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PoolBullet : MonoBehaviour {

	bool canFire = true;//if true runs the while loop in the coroutine.
	public List<GameObject> bullets;//a list of bullet GameObjects.

	//runs at the start of the game.
	void Start () { 
		//adds the AddBulletsToList function to
		//the BulletClass.SendBullet action.
		BulletClass.SendBullet += AddBulletsToList;
		StartCoroutine(RecycleBullets());//starts the RecycleBullets coroutine
	}
    private void AddBulletsToList(GameObject obj)
    {
		if(obj.tag == gameObject.tag)
        	bullets.Add(obj);//adds the bullet GameObjects to the bullets list
    }

	IEnumerator RecycleBullets () {
		yield return new WaitForEndOfFrame();//waits to run at the end of a frame
		while (canFire)//checks if canFire is true.
		{
			bullets[0].transform.position = transform.position;
			bullets[0].SetActive(true);//sets the first bullet in the list to active.
			bullets.RemoveAt(0);//removes the list item in the postion of the number.
			yield return new WaitForSeconds(1);//holds for second to loop back
		}
	}
}
