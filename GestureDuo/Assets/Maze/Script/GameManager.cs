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
            Time.timeScale = 1;
            //TODO: do next level
        }

        public void MainMenu()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("MazeMenu");
        }
    }
}