using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletDanmaku : MonoBehaviour
{


    public float bulletLifetime = 1.0f;
    public float rotation = 0.0f;
    public float bulletSpeed = 12f;
    private Vector2 spawnLocation;
    private float timer = 0.0f;
    public Rigidbody2D damakuBulletRB;
    public GameObject danmakuBullet;
    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = new Vector2(transform.position.x, transform.position.y);

        Destroy(gameObject, bulletLifetime);

        damakuBulletRB = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    {
        
    }


}
