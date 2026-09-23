using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;

public class enemyHP : MonoBehaviour
{
    public int enemyHealth;
    public SpriteRenderer enemySpriteRend;
    public GameObject enemyExplosion;


    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "bulletPlr")
        {

            enemyHealth -= 20;

            StartCoroutine(damageEffect());


            if (enemyHealth <= 0)
            {


                Instantiate(enemyExplosion, transform.position, Quaternion.identity);
                Destroy(gameObject);

            }



        }

        IEnumerator damageEffect()
        {

        enemySpriteRend.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        enemySpriteRend.color = Color.white;

        }
    }
}
