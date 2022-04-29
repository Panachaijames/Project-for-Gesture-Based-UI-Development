using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class MenuManager : MonoBehaviour
    {
        public GameObject GameChoicePanel;
        public GameObject MenuPanel;

        public void ShowGameChoice()
        {
            MenuPanel.SetActive(false);
            GameChoicePanel.SetActive(true);
        }

        public void Back()
        {
            MenuPanel.SetActive(true);
            GameChoicePanel.SetActive(false);
        }

        public void PlayHockey()
        {
            SceneManager.LoadScene("HockeyMenu");
        }

        public void PlayFlappy()
        {
            SceneManager.LoadScene("FlappyBirdMenu");
        }
    }
}