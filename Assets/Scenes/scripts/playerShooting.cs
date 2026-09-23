using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{

    [SerializeField] private GameObject smallBullet;
    [SerializeField] private GameObject missile;
    [SerializeField] private GameObject inkPlatform;

    [SerializeField] private int ink;
    [SerializeField] private Transform projectileTransform;

    public bool canCreateInkPlatform;
    public bool canShootSmallBullet;
    public bool canShootMissile;

    [SerializeField] private float smallBulletTimer;
    [SerializeField] private float missileTimer;
    [SerializeField] private float inkPlatformTimer;
    [SerializeField] private float fuel;


    public float timeBetweenSmallBullets;
    public float timeBetweenMissiles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!canShootSmallBullet)
        
        {
            smallBulletTimer += Time.deltaTime;

                if(smallBulletTimer > timeBetweenSmallBullets)
                {
                    canShootSmallBullet = true;
                    smallBulletTimer = 0;
                }
        }
        if(!canShootMissile)
        
        {
            missileTimer += Time.deltaTime;

                if(missileTimer > timeBetweenSmallBullets)
                {
                    canShootMissile = true;
                    missileTimer = 0;
                }
        }

        if(ink > 0)

        {
            //inkPlatformTimer += Time.deltaTime;

            //if (inkPlatformTimer > timeBetweenMissiles)
            //{
            canCreateInkPlatform = true;
            ink--;

            if (ink <= 0)
            {

                canCreateInkPlatform = false;

            }


                //missileTimer = 0;
            
            //}
        }
        //else
        //{

         //   canCreateInkPlatform = false;
       // }

        if (Input.GetMouseButton(0) && canShootSmallBullet)
        
        {
            canShootSmallBullet = false;
            shootSmallBullet();


        }
        if(Input.GetMouseButton(2) && canShootMissile)
        {
            shootMissile();


        }
        if (Input.GetMouseButton(1) && canCreateInkPlatform)
        {
            CreateInkPlatform();


        }



    }



    private void shootSmallBullet()
    
    {

        Instantiate(smallBullet, projectileTransform.position, Quaternion.identity);

    }

    private void shootMissile()
    
    {

        Instantiate(missile, projectileTransform.position, Quaternion.identity);

    }

    private void CreateInkPlatform()
    {

        Instantiate(inkPlatform, projectileTransform.position, Quaternion.identity);

       // ink--;

    }
}
