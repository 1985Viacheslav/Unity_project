using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject level;

    public void StartGame()
    {
        SceneManager.LoadScene("Game-1");
    }

    public void ShowLevel()
    {
        menu.SetActive(false);
        level.SetActive(true);
    }
    
    public void ShowMenu()
    {
        menu.SetActive(true);
        level.SetActive(false);
    }

    public void SelectLevel(int index)
    {
        SceneManager.LoadScene($"Game-{index}");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
