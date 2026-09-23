using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingControl : MonoBehaviour
{

    public float timeBetweenShots;
    public GameObject projectile;
    public Transform projectilePos;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // timer will go up in seconds

        if(timer >= timeBetweenShots)
        {
            shootBullet();
            timer = 0;
            


        }
    }

    void shootBullet()
    {

        Instantiate(projectile, projectilePos.position, Quaternion.identity); //bulletpos.position acesses the position

    }
}
