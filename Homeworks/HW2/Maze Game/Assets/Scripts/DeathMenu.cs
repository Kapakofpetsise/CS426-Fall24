using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public Camera deathCamera;
    public GameObject deathMenuUI;

    public void ShowDeathMenu()
    {
        deathCamera.gameObject.SetActive(true);
        // Show the death menu UI
        deathMenuUI.SetActive(true);
        // Pause the game
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Retry()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        // Restart the current scene
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
