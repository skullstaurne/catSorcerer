using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerShooting : MonoBehaviour
{
    public Rigidbody2D bulletRB;
    public float bulletVelocity = 15f;
    public float timeBetweenShots;
    public GameObject projectile;
    public Transform projectilePos1;
    public Transform projectilePos2;
    public Transform projectilePos3;
    public Transform projectilePos4;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // timer will go up in seconds

        if (timer >= timeBetweenShots)
        {
            shootBullet();
            timer = 0f;



        }
    }

    void shootBullet()
    {

        Instantiate(projectile, projectilePos1.position, projectilePos1.rotation);//bulletpos.position acesses the position
                          
       // Instantiate(projectile, projectilePos2.position, projectilePos2.rotation);
        //Instantiate(projectile, projectilePos3.position, projectilePos3.rotation);
        //Instantiate(projectile, projectilePos4.position, projectilePos4.rotation);
       // bulletRB.velocity = transform.up * bulletVelocity * Time.deltaTime;

    }
}
