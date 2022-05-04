using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Dice
{
    public class Menu : MonoBehaviour
    {
        public void Play()
        {
            SceneManager.LoadScene("Dice");

            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
        }

        public void Quit()
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
