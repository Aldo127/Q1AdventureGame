using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorUnlock : MonoBehaviour
{
    public GameObject door;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("key"))
        {
            Destroy(other.gameObject);
            Destroy(door);
            Debug.Log("HUH");
        }
    }
}
