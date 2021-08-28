using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaisingLava : MonoBehaviour
{
    private bool isOn;
    private Animator lavaAnimator;
    public GameObject blocker;
    // Start is called before the first frame update
    void Start()
    {
        lavaAnimator = GetComponent<Animator>();
        isOn = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if((PlayerPrefs.GetString("Raising Lava") == "False") && (!isOn))
            {
                Invoke(nameof(SpawnBlocker), 1);
                isOn = true;
                lavaAnimator.SetBool("IsDebuffed", true);
            }
        }
    }
    private void SpawnBlocker()
    {
        Instantiate(blocker, new Vector2(transform.position.x + 1.82f, transform.position.y - 0.6f), transform.rotation);
        Instantiate(blocker, new Vector2(transform.position.x - 11f, transform.position.y - 0.6f), transform.rotation);

    }
}
