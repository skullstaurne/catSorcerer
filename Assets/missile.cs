using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    private Vector3 mousepos;
    private Camera mainCam;
    private Rigidbody2D missileRB;
    public float missileBulletForce;
    // Start is called before the first frame update
    void Start()
    {
        missileRB = GetComponent<Rigidbody2D>();
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        mousepos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 missileDirection = mousepos - transform.position;


        Vector3 missileRotation = transform.position - mousepos;

        missileRB.velocity = new Vector2(missileDirection.x, missileDirection.y).normalized * missileBulletForce; //set velocity of the bullet to the direction on axis x and y
        float rot = Mathf.Atan2(missileRotation.y, missileRotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);


    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 0.6f);
    }
}
