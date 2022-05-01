using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MazeTilt
{
    public class GameManagerLevel3 : MonoBehaviour
    {
        public GameObject victoryCanvas;

        public void Victory()
        {
            Time.timeScale = 0;
            victoryCanvas.SetActive(true);

        }
        public void NextLevel()
        {
            SceneManager.LoadScene("MazeLevel4");
            Time.timeScale = 1;
        }
        public void Replay()
        {
            SceneManager.LoadScene("MazeLevel3");
            Time.timeScale = 1;
        }

        public void MainMenu()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("MazeMenu");
        }
    }
}
