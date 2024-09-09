using UnityEngine;


public class GunComponent : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float chargeSpeed = 10f;
    private float chargeTime = 0f;

    void Update()
    {

        if (Input.GetButtonUp("Fire1"))
        {
            // Spawn bullet when Fire1 is released
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            BulletComponent bulletComp = bullet.GetComponent<BulletComponent>();
            bulletComp.bulletSpeed*= chargeTime;

        }

        if (Input.GetButton("Fire1"))
        {
            chargeTime = chargeTime + Time.deltaTime;
            chargeTime = Mathf.Clamp(chargeTime,0,3);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            chargeTime = 0f;
        }
    }

}
