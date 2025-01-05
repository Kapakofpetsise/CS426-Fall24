using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Key")) // Check if the colliding object is the key
        {
            // Destroy the key
            Destroy(collision.gameObject);
            // Destroy the door
            Destroy(gameObject);

        }
    }
}
