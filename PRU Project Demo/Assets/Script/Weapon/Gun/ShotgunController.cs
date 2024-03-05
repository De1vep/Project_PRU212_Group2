using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunController : WeaponController
{
    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void Attack()
    {
        base.Attack();

        for (int i = 0; i < 6; i++)
        {
            Instantiate(prefab, GunPoint.position, Quaternion.Euler(GunPoint.eulerAngles.x, GunPoint.eulerAngles.y, GunPoint.eulerAngles.z + Random.Range(-spread, spread)));
        }

    }
}
