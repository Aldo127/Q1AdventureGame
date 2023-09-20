using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour
{
    public bool playerIsClose;
    Rigidbody2D rb;
    public Animator ani;
    private Animation anim;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            ani.SetBool("TRASH", true);
            //anim.Play("Laser");
        }
        
    //    if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
    //    {
    //        ani.SetBool("TRASH", true);
    //        //anim.Play("Laser");
    //    }
    }
    
        
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;

        }
    }
}
