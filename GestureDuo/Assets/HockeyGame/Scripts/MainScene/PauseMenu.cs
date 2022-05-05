using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Hockey
{
    public class PauseMenu : MonoBehaviour
    {
        public GameObject pausePanel;

        public void Pause()
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
        public void Resume()
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
        }
        public void Menu()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("HockeyMenu");
        }
    }
}