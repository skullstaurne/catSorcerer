using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;


public class enemyAI : MonoBehaviour
{
    private Transform target;
    public float speed = 10f;
    public float stoppingDistance;
    public float backAwayDistance;




    // Start is called before the first frame update
    void Start()
    {

        target = GameObject.FindGameObjectWithTag("Player").transform;
       
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        
   
        {

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }

        else if(Vector2.Distance(transform.position, target.position) < stoppingDistance && Vector2.Distance(transform.position, target.position ) > backAwayDistance){

            transform.position = this.transform.position;

        }

        else if(Vector2.Distance(transform.position, target.position) < backAwayDistance){

            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);

        }
        

    }
}
