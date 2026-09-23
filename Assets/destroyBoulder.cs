using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBoulder : MonoBehaviour
{

    //[SerializeField] private Animator explosionAnimator;
    // Start is called before the first frame update
    void Start()
    {
       // Destroy(gameObject, explosionAnimator.GetCurrentAnimatorStateInfo(0).length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destroy()
    {
        Destroy(gameObject, .2f);
    }
}
