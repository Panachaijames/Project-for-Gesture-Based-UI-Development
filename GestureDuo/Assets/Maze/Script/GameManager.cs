using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MazeTilt
{
    public class GameManager : MonoBehaviour
    {
        public GameObject victoryCanvas;

        public void Victory()
        { 
            Time.timeScale = 0;
            victoryCanvas.SetActive(true);
           
        }

        public void Replay()
        {
            SceneManager.LoadScene("Maze");
            Time.timeScale = 1;
        }

        public void NextLevel()
        {
            SceneManager.LoadScene("MazeLevel2");
            Time.timeScale = 1;
        }

        public void MainMenu()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("MazeMenu");
        }
    }
}