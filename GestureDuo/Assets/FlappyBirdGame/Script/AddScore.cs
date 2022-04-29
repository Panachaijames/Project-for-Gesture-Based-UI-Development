using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    public class AddScore : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Score.score++;
        }
    }
}