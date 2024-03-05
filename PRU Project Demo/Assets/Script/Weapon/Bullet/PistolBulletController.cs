using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBulletController : BulletController
{    
    protected PistolController controller;
    
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        controller = FindObjectOfType<PistolController>();
        bulletSpawnPoint = controller.GunPoint.position;
        rb.velocity = transform.right * controller.speed;
        transform.up = controller.GunPoint.right;
    }

    private void Update()
    {
        dis = Vector2.Distance(transform.position, bulletSpawnPoint);
        if (dis >= controller.range)
        {
            Destroy(gameObject);
        }
    }

}
