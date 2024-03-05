using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShotgunBulletController : BulletController
{
    protected ShotgunController controller;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        controller = FindObjectOfType<ShotgunController>();
        bulletSpawnPoint = controller.GunPoint.position;
        rb.velocity = transform.right * controller.speed;
        transform.up = controller.GunPoint.right;

    }

    // Update is called once per frame
    void Update()
    {
        dis = Vector2.Distance(transform.position, bulletSpawnPoint);
        Debug.Log(dis);
        if (dis >= controller.range)
        {
            Destroy(gameObject);
        }
    }
}
