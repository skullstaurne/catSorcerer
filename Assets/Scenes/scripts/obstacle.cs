using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{


    float wait = 0.1f;
    float inkBottleWait = 0.2f;

    public GameObject fallingObstacle;
   // public GameObject inkBottle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("fall", wait, wait);
        //InvokeRepeating("fallingInkBottle", 3.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void fall(){


        Instantiate(fallingObstacle, new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity);


    }

        void fallingInkBottle(){


        //Instantiate(inkBottle, new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity);


    }


   

}
