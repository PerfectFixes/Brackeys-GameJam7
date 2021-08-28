using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseLava : MonoBehaviour
{
    private Animator animating;
    // Start is called before the first frame update
    void Start()
    {
        animating = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(PlayerPrefs.GetString("Raising Lava") == "False")
            {
                animating.SetBool("IsDebuffed", true);
            }
        }
    }
}
