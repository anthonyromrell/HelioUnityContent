using UnityEngine;
using System;

public class BulletClass : MonoBehaviour
{
    public static Action<GameObject> SendBullet;

    void Start()
    {
        SendBullet(gameObject);
		gameObject.SetActive(false);
    }
    void OnEnable()
    {
		transform.position = new Vector3();
		GetComponent<Rigidbody>().AddForce(200,0,0);
        if (SendBullet != null)
        {
            SendBullet(gameObject);
            Invoke("Disable", 10);
		}
    }
    void Disable()
    {
        gameObject.SetActive(false);
		GetComponent<Rigidbody>().Sleep();
    }
}
