using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject playPanel;

    void Start()
    {
        Time.timeScale = 0f;

        playPanel.SetActive(true);
        pausePanel.SetActive(false);
    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
        playPanel.SetActive(false);
        pausePanel.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }

    public void ExitToMenu()
    {
        Time.timeScale = 0f;

        pausePanel.SetActive(false);
        playPanel.SetActive(true);
    }
}