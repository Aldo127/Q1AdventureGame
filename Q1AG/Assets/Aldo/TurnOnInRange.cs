using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnInRange : MonoBehaviour
{
    public GameObject ObjectToActivate;
    public bool instantiateObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (instantiateObject)
            {
                Instantiate(ObjectToActivate, transform.position, transform.rotation);
            }
            else
            {
                ObjectToActivate.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ObjectToActivate.SetActive(false);
        }
    }

}
