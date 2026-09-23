using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprites : MonoBehaviour
{

    [SerializeField] Sprite[] boulderSprites;
    [SerializeField] Sprite newSprite;
    // Start is called before the first frame update
    public int boulderHP = 30;

    private void OnCollisionEnter2D(Collision2D collision)

    {
        newSprite = boulderSprites[Random.Range(0, boulderSprites.Length)];


    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
