using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlaneShooting : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float bulletCount = 10;
    public float ammoPickUp = 5;
    public TextMeshProUGUI ammoDisplay;

    
    void Update()
    {
        ammoDisplay.text = bulletCount.ToString();
        if(bulletCount > 0)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

                bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * bulletSpeed;

                bulletCount = bulletCount - 1;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ammo"))
        {
            bulletCount = bulletCount + ammoPickUp;
            Destroy(collision.gameObject);
        }
    }
}
