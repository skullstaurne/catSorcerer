using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishManager : MonoBehaviour
{

    public int fishCount;
    public Text fishText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fishText.text = fishCount.ToString() + " / 3"; // to stringkoska tehd‰‰n integerist‰ string
    }
}
