using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        // Hide and lock the cursor
        Cursor.lockState = CursorLockMode.Locked; // Locks the cursor to the center of the screen
        Cursor.visible = false; // Makes the cursor invisible
    }

    private void Update()
    {
        // Optional: Toggle cursor visibility with a key (for debugging or UI menus)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None; // Unlock the cursor
            Cursor.visible = true; // Make the cursor visible
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            Cursor.lockState = CursorLockMode.Locked; // Relock the cursor
            Cursor.visible = false; // Hide the cursor again
        }
    }
}
