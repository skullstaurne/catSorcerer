using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDanmakuSpawner : MonoBehaviour
{

    public float bulletLifetime = 1.0f;
    public float rotation = 0.0f;
    public float bulletSpeed = 1.0f;
    private Vector2 spawnLocation;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
