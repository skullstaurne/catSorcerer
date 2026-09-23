using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class plrController : MonoBehaviour
{

    public fishManager fishM;
    public int fishCollected = 0;
    public GameObject winUI;

    float leftRightMovement;
    public Rigidbody2D plrRB;
    public SpriteRenderer spriteRend;
    public float movementSpeed = 10f;
    //public float jumpAmount = 35;
    public float gravityScaleJumping;
    public float groundCheckRadius = 0.2f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public LayerMask magicLayer;
    public Animator anim;

    [SerializeField] int jumpAmount = 1;
    [SerializeField] int extraJumpAmount;

    public float jumpingForce = 5f;

    public bool isGrounded;
    public bool isInAirFalling;

    public float HP;
    public float MaxHP = 100;
    public Image hpBar;

    public event Action plrIsDead;//game ctrl subs to this to know when plr dies
    // Start is called before the first frame update
    void Start()
    {
        MaxHP = HP;

        plrRB = GetComponent<Rigidbody2D>();
        spriteRend = GetComponent<SpriteRenderer>();

        extraJumpAmount = jumpAmount;

        winUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        hpBar.fillAmount = Mathf.Clamp(HP / MaxHP, 0, 1);

        leftRightMovement = Input.GetAxisRaw("Horizontal");


        if (isGrounded)
        {
            extraJumpAmount = jumpAmount;

        }

        if (Input.GetKeyDown(KeyCode.Space))

        {

            if (isGrounded)
            {
                plrRB.velocity = new Vector2(plrRB.velocity.x, jumpingForce);
            }

            else if (extraJumpAmount > 0)
            {

                plrRB.velocity = new Vector2(plrRB.velocity.x, jumpingForce);
                extraJumpAmount--;

            }



            //plrRB.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }



    }


    private void FixedUpdate() {

        plrRB.velocity = new Vector2(leftRightMovement * movementSpeed, plrRB.velocity.y);
        plrRB.AddForce(Physics.gravity * (gravityScaleJumping - 1) * plrRB.mass);

        spriteRend.flipX = plrRB.velocity.x > 0f;

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

       

        if (leftRightMovement != 0)
        {
            anim.SetBool("isRunning", true);

        }
        else 
        {
            anim.SetBool("isRunning", false);

        
        }


        
        if (isGrounded == false && leftRightMovement == 0)
        {
            anim.SetBool("isFalling", true);
            anim.SetBool("isRunning", false);

        }
        else
        {
            anim.SetBool("isFalling", false);


        }

    }

    private void OnCollisionEnter2D(Collision2D col) {

        if (col.gameObject.tag == "damage")
        {

            HP -= 3;
            plrRB.velocity = new Vector2(plrRB.velocity.x, jumpingForce); //knockback
            StartCoroutine(damageEffect());


            if (HP <= 0)
            {

                plrIsDead.Invoke(); //telling game controller THAT plr died
                Destroy(gameObject);

            }



            if (col.gameObject.tag == "inkBottle")
            {




            }


        }

    }

    //if(col.gameObject.tag == "bulletEnemy"){

    //HP -= 20;

    // StartCoroutine(damageEffect());


    //if(HP <= 0)
    //{

    //  plrIsDead.Invoke(); //telling game controller THAT plr died
    //  Destroy(gameObject);

    // }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("bulletEnemy"))
        {

            HP -= 20;
            plrRB.velocity = new Vector2(plrRB.velocity.x, jumpingForce);
            StartCoroutine(damageEffect());


            if (HP <= 0)
            {

                plrIsDead.Invoke(); //telling game controller THAT plr died
                Destroy(gameObject);

            }



        }
        if (col.CompareTag("fishHearth"))
        {
            Destroy(col.gameObject); //tuhoa se asia, mihin osuttiin

            fishM.fishCount++;
            fishCollected++;

            if(fishCollected >= 3)
            {
                winUI.SetActive(true);

            }

        }



    }







    private IEnumerator damageEffect() {

        spriteRend.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRend.color = Color.white;


    }
    
}
