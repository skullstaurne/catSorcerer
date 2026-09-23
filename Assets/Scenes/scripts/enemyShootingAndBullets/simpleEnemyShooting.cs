using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleEnemyShooting : MonoBehaviour
{

    private GameObject plr;
    private Rigidbody2D rb;
    public float bulletVelocity; // speedofbullet
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        plr = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = plr.transform.position - transform.position; //transform.position is bullet position
        rb.velocity = new Vector2(direction.x, direction.y).normalized * bulletVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
