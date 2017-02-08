using UnityEngine;
using System;

public class BulletClass : MonoBehaviour
{
    //Sends the bullet gameObject to any adding function.
    public static Action<GameObject> SendBullet;
    //PoolBullet is added to it.

    void Start()
    {
        SendBullet(gameObject);//Calls the action and passes the bullet gameObject.
        gameObject.SetActive(false);//turns the bullet off at the start.
    }
    //OnEnable() is a Unity function that runs when an object is activated
    void OnEnable()
    {
        //transform.position = new Vector3();// resets the bullet position
        GetComponent<Rigidbody>().AddForce(200, 0, 0);//gets the rigid body and adds force to x

        if (SendBullet != null)//checks if SendBullet doesn't contain functions 
        {
            SendBullet(gameObject);//Calls the action and passes the bullet gameObject.
            Invoke("Disable", 10);//Delays the Disable function by 10 seconds
        }
    }
    void Disable()
    {
        gameObject.SetActive(false);//turns off the bullet gameObject.
        GetComponent<Rigidbody>().Sleep();//stops the Rigidbody forces.
    }
}
