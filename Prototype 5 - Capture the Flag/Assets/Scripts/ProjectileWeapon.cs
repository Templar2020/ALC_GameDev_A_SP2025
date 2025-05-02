using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeapon : MonoBehaviour
{
    [Header("Projectile")]
    public GameObject projectile;
    public Transform firePoint;

    public float projectileSpeed;
    private bool isPlayer;

    [Header("Shoot Rate & Time")]
    public float shootRate;
    private float lastShootTime;
    [Header("Ammo")]
    public int curAmmo;
    public int maxAmmo;
    public bool infiniteAmmo;

    void Awake()
    {
        //are we attached to the player?
        if(GetComponent<PlayerController>())
            isPlayer = true;
    }
    public bool CanShoot()
    {
       if(Time.time - lastShootTime >= shootRate)
       {
            if(curAmmo > 0 || infiniteAmmo)
                return true;
       }

       return false;
    }

    public void Shoot()
    {
        //Cooldown and reduce ammo 
        lastShootTime = Time.time;
        curAmmo--;
        //Instantiate projectile
        GameObject projectileObject = Instantiate(projectile, firePoint.position, firePoint.rotation);

        // set the velocity of the projectile
        projectileObject.GetComponent<Rigidbody>().velocity = firePoint.forward * projectileSpeed;
    }
}