using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D rb;
    protected Vector2 bulletSpawnPoint;
    protected float dis;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        Destroy(gameObject, 5);        
    }

}
