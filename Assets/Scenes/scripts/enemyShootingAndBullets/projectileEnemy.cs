using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileEnemy : MonoBehaviour
{

    public float speed;

    private Vector3 bulletRot;

    private Transform player;
    private Vector3 target;
    public Transform targetrot;
    
    //private Vector3 bulletRot;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; //FIND THE TRANSFORM OF PLR
        target = new Vector3(player.position.x, player.position.y); //TARGET IS EQUAL TO POSISION OF PLR WHEN BULLET IS SPAWNED
       
       bulletRot = transform.position - target; //rotate torwards the player
       
        float rot = Mathf.Atan2(bulletRot.y, bulletRot.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        //
        Vector3 dir = targetrot.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
//

        //Vector3 dir = target - transform.position;


        if(transform.position.x == target.x && transform.position.y == target.y)
        {

            DestroyProjectile();


        }
    }

    void OnTriggerEnter2D(Collider2D other){


        if(other.CompareTag("Player"))

        {
            DestroyProjectile();
        }

    }


    void DestroyProjectile(){



        Destroy(gameObject);
    }

}
