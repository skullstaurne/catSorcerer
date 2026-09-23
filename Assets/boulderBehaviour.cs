using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulderBehaviour : MonoBehaviour
{

    public SpriteRenderer sr;
    public int boulderDurability = 12;
    public Animator animBoulderBreak;
    public GameObject boulderExplosionPrefab;

    public Sprite noDamage;
    public Sprite smallDamage;
    public Sprite midDamage;
    public Sprite heavyDamage;

   // public GameObject boulderExplosion;
    // Start is called before the first frame update
    void Start()
    {
        Animator animBoulderbreak = GetComponent<Animator>();
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void destroyBoulder()
    {



        // animBoulderBreak.Play();
         //Destroy(gameObject);
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "bulletPlr")
        {

            boulderDurability -= 1;

            if (boulderDurability <= 0)
            {


                Instantiate(boulderExplosionPrefab, transform.position, Quaternion.identity);
               // destroyBoulder();
                Destroy(gameObject);

            }



            else if (boulderDurability > 9 && boulderDurability < 12)
            {


                
                StartCoroutine(damageEffect());
                sr.sprite = smallDamage;

            }
            else if (boulderDurability > 6 && boulderDurability < 9)
            {



                StartCoroutine(damageEffect());

                sr.sprite = midDamage;
            }

            else if (boulderDurability > 0 && boulderDurability < 6)
            {



                StartCoroutine(damageEffect());

                sr.sprite = heavyDamage;

            }

        }

        IEnumerator damageEffect()
        {

            sr.color = Color.red;
            yield return new WaitForSeconds(0.1f);
            sr.color = Color.white;

        }
    }
}
