using UnityEngine;

public class GunShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float shootPower = 2000f;

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        Vector3 dir = Camera.main.transform.forward;

        bullet.GetComponent<Rigidbody>().AddForce(dir * shootPower, ForceMode.Impulse);
    }
}
