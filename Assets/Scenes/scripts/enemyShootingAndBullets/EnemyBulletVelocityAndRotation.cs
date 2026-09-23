using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletVelocityAndRotation : MonoBehaviour
{

    public float bulletVelocity;
    public Rigidbody2D rb;
    public Transform plr;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        plr = GameObject.FindGameObjectWithTag("Player").transform;
        //transform.position = plrTraget - transform.position;
        ////target = new Vector3(plr.position.x, plr.position.y);

        Vector3 direction = plr.transform.position - transform.position; //transform.position is bullet position
        rb.velocity = new Vector2(direction.x, direction.y).normalized * bulletVelocity;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
