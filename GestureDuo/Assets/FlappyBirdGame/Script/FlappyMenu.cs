using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("FlappyBird");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
