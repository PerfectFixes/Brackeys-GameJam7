using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadPlatforms : MonoBehaviour
{
    private Renderer changeColor;
    // Start is called before the first frame update
    void Start()
    {
        changeColor = GetComponent<Renderer>();
        if (PlayerPrefs.GetString("Bad Platform") == "False")
        {
            print("Changing Color ");

            changeColor.material.color = Color.red;
            //Change the tag 
            transform.gameObject.tag = "Lava";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
