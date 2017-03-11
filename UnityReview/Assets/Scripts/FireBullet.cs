using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject bullet;
	public float force = 10;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject bulletPrefab = Instantiate(bullet, transform.position,
                                                    transform.rotation);
            bulletPrefab.GetComponent<Rigidbody>().AddForce(transform.forward * force);
        }
    }
}
