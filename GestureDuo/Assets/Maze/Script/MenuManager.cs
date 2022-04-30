using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MazeTilt
{
    public class MenuManager : MonoBehaviour
    {
        
        public GameObject levelPanel;
        public GameObject panel;

        public void Play()
        {
            SceneManager.LoadScene("Maze");
        }
        public void Level()
        {
            panel.SetActive(false);
            levelPanel.SetActive(true);
        }
        public void Menu()
        {
            SceneManager.LoadScene("Menu");
        }

        public void Level2()
        {
            //TODO: do & link to scene level2
        }
        public void Level3()
        {
            //TODO: do & link to scene level3
        }

        public void Back()
        {
            levelPanel.SetActive(false);
            panel.SetActive(true);
        }
    }
}