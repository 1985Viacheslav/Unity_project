using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject root;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            AudioListener.pause = true;

            root.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        AudioListener.pause = false;

        root.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Exite()
    {
        SceneManager.LoadScene("MainMenu");
        AudioListener.pause = false;
        Time.timeScale = 1f;
    }
}
