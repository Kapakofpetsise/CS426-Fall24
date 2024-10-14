using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubeScript : MonoBehaviour
{
    public GameObject prefabToSpawn;

    public Transform spawnPoint;

    public KeyCode spawnKey = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(spawnKey))
        {
            SpawnPrefab();
        }
    }

    void SpawnPrefab()
    {
        if (prefabToSpawn != null && spawnPoint != null)
        {
            Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            Debug.LogError("Prefab or spawn point is not assigned.");
        }
    }
}