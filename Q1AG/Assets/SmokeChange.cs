using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeChange : MonoBehaviour
{
    [SerializeField] private ParticleSystem testParticleSystem = default;

    public bool playerIsClose;
    public GameObject smoke;
 //   public Sprite gooseDisguise;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && playerIsClose)
        {
           // testParticleSystem.Play();
            Debug.Log("test");
            smoke.SetActive(true);
           // this.gameObject.GetComponent<SpriteRenderer>().sprite = gooseDisguise;
        }
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
