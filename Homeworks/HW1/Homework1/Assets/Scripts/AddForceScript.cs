using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddForceScript : MonoBehaviour
{
    public Rigidbody rb;

    public Vector3 forceAmount = new Vector3(0, 1000, 0); 

    void Start()
    {
    }

    void Update()
    {
        if (rb != null)
        {
            rb.AddForce(forceAmount * Time.deltaTime, ForceMode.Force);
        }
    }
}

