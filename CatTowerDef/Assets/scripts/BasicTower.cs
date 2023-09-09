using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTower :Tower
{
    public Transform pivot;
    public Transform barrel;
    public GameObject bullet;
    protected override void shoot()
    {
        base.shoot();

        GameObject newBullet = Instantiate(bullet,barrel.position,pivot.rotation);
    }
}
