using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorUnlock2 : MonoBehaviour
{
    public GameObject door;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("bkey"))
        {
            Destroy(other.gameObject);
            Destroy(door);
            
        }
    }
}

