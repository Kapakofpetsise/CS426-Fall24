using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Patrol Settings")]
    public Transform pointA; // First patrol point
    public Transform pointB; // Second patrol point
    public float patrolSpeed = 2f; // Speed of patrolling

    [Header("Death Menu")]
    public DeathMenu deathMenu; // Reference to the Death Menu UI

    private Transform currentTarget;

    private void Start()
    {
        // Start patrolling towards pointA
        currentTarget = pointA;

    }

    private void Update()
    {
        Patrol();
    }

    private void Patrol()
    {
        // Move towards the current target point
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, patrolSpeed * Time.deltaTime);

        // If the enemy reaches the current target point, switch to the other point
        if (Vector3.Distance(transform.position, currentTarget.position) < 0.1f)
        {
            currentTarget = (currentTarget == pointA) ? pointB : pointA;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            KillPlayer(other.gameObject);
        }
    }

    private void KillPlayer(GameObject player)
    {
        Debug.Log("Player has been killed!");

        deathMenu.ShowDeathMenu();
        Debug.Log("Death Menu has been shown!");
        // Destroy the player object
        Destroy(player);

        // Show the death menu
        
        
    }
}
