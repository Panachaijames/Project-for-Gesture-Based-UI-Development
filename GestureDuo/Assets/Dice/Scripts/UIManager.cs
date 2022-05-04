using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Dice
{
    public class UIManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

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

        public void Quit()
        {
            SceneManager.LoadScene("Menu");
        }

        public void Back()
        {
            SceneManager.LoadScene("DiceMenu");
        }
    }
}
