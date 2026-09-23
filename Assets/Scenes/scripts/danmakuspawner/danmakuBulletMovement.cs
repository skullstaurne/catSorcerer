using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danmakuBulletMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float bulletVelocity = 20f;
    // Start is called before the first frame update


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * bulletVelocity * Time.deltaTime;
        Debug.Log(rb.velocity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
