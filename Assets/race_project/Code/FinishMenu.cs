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
        Time.timeScale = 0;   
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Next(string levelName)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(levelName);
    }

    public void Back()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
