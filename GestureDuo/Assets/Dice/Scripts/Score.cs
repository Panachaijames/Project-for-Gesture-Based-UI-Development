using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dice
{
    public class Score : MonoBehaviour
    {

        public float score1;
        public float score2;
        float finalScore;
        public Text scoreText;
        void Start()
        {
            scoreText.text = "0";
        }
        void Update()
        {
            finalScore = (score1 + score2);
            scoreText.text = finalScore.ToString();
            //Debug.Log(score2);
        }
    }
}