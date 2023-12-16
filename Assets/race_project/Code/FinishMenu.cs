using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishMenu : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject bestScore;
    public GameObject otherScore;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Time.timeScale = 0;

        AudioListener.pause = true;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Next(string levelName)
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene(levelName);
    }

    public void Back()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene("MainMenu");
    }
}
