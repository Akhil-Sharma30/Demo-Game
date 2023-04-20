using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorVisible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Lock cursor to center of screen and hide it
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
    {
        // Unlock cursor and show it
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Load Main Menu scene
        SceneManager.LoadScene("MainMenu");
    }
    }
}
