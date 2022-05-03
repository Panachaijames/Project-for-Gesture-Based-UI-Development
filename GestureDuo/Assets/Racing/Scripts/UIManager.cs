using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Ambulance
{
    public class UIManager : MonoBehaviour
    {
        public Text scoreText;
        bool gameOver;
        int score;

        // Start is called before the first frame update
        void Start()
        {
            gameOver = false;
            score = 0;
            InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
        }

        // Update is called once per frame
        void Update()
        {
            scoreText.text = "Score: " + score;
        }

        void scoreUpdate()
        {
            if(!gameOver)
            {
                score += 1;
            }
            
        }

        public void Pause()
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
        }

        public void Resume()
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
        }

        public void Play()
        {
            SceneManager.LoadScene("Racing");

            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
        }

        public void Quit()
        {
            SceneManager.LoadScene("Menu");
        }

        public void Back()
        {
            SceneManager.LoadScene("RacingMenu");
        }

        public void gameOverActivated()
        {
            gameOver = true;
        }
    }
}
