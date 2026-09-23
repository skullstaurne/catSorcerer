using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateDeathUI : MonoBehaviour
{

    public GameObject deathUI;
    public plrController plrHP;
    public bool plrDead = false;

    // Start is called before the first frame update
    void Start()
    {
       // deathUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!plrDead && plrHP.HP <= 0)
        {
            Debug.Log("dead");
            plrDead = true;
            deathUI.SetActive(true);
        }
    }
}
