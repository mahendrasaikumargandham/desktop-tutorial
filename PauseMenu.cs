using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool gameIsStoped = false;   
    public GameObject pauseMenu;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(gameIsStoped) {
                ResumeGame();
            }
            else {
                PauseGame();
            }
        }
    }

    public void ResumeGame() {
        pauseMenu.SetActive(false);
        gameIsStoped = false;
    }

    public void PauseGame() {
        pauseMenu.SetActive(true);
        gameIsStoped = true;
    }

    public void MainScreen() {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitApplication() {
        Application.Quit();
    }
}
