using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;

    public Canvas winScreen;

    public float restartDelay = 1f;

    private void Start()
    {
        winScreen.enabled = false;
    }

    public void EndGame()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ShowCanvas()
    {
        winScreen.enabled = true;
        Invoke("WinLevel", 1f);
    }

    public void WinLevel()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1));
    }
}
