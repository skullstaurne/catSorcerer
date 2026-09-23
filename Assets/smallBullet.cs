using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallBullet : MonoBehaviour
{

    private Vector3 mousepos;
    private Camera mainCam;
    private Rigidbody2D smallBulletRB;
    public float smallBulletForce;
    // Start is called before the first frame update
    void Start()
    {
        smallBulletRB = GetComponent<Rigidbody2D>();
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        mousepos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 smallBulletDirection = mousepos - transform.position;


        Vector3 smallBulletRotation = transform.position - mousepos;

        smallBulletRB.velocity = new Vector2(smallBulletDirection.x, smallBulletDirection.y).normalized * smallBulletForce; //set velocity of the bullet to the direction on axis x and y
        float rot = Mathf.Atan2(smallBulletRotation.y, smallBulletRotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);


    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
