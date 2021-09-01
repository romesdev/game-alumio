using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_2 : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform firePoint_2;
    public GameObject bulletPrefab_2;
    public float bulletForce = 10f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
        if(Input.GetButtonDown("Fire2")){
            Shoot_2();
        }
    }

    void Shoot(){
        GameObject bullet = Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
    void Shoot_2(){
        GameObject bullet = Instantiate(bulletPrefab_2,firePoint_2.position,firePoint_2.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint_2.up * bulletForce, ForceMode2D.Impulse);
    }
}
