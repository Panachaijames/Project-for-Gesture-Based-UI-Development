using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dice
{
    [RequireComponent(typeof(PhysicsController))]
    public class Dice2 : MonoBehaviour
    {
        public float ShakeDetectionThreshold;
        public float MinShakeInterval;

        private float sqrShakeDetectionThreshold;
        private float timeSinceLastShake;

        private PhysicsController physicsController;

        // Array of dice sides sprites to load from Resources folder
        private Sprite[] diceSides;

        // Reference to sprite renderer to change sprites
        private SpriteRenderer rend;

        public Score score;

        // Use this for initialization
        private void Start()
        {
            
            // Assign Renderer component
            rend = GetComponent<SpriteRenderer>();

            // Load dice sides sprites to array from DiceSides subfolder of Resources folder
            diceSides = Resources.LoadAll<Sprite>("DiceSides/");

            //Shake
            sqrShakeDetectionThreshold = Mathf.Pow(ShakeDetectionThreshold, 2);
            physicsController = GetComponent<PhysicsController>();
        }

        void Update()
        {
            if (Input.acceleration.sqrMagnitude >= sqrShakeDetectionThreshold
                && Time.unscaledTime >= timeSinceLastShake + MinShakeInterval)
            {
                physicsController.ShakeRigidbodies(Input.acceleration);
                timeSinceLastShake = Time.unscaledTime;

                StartCoroutine("RollTheDice");
            }
        }
        // If you left click over the dice then RollTheDice coroutine is started
        /* private void OnMouseDown()
         {
             StartCoroutine("RollTheDice");
         }*/
        // Coroutine that rolls the dice
        private IEnumerator RollTheDice()
        {
            // Variable to contain random dice side number.
            // It needs to be assigned. Let it be 0 initially
            int randomDiceSide = 0;
             // Final side or value that dice reads in the end of coroutine
            int finalSide2 = 0;
            // Loop to switch dice sides ramdomly
            // before final side appears. 20 itterations here.
            for (int i = 0; i <= 20; i++)
            {
                // Pick up random value from 0 to 5 (All inclusive)
                randomDiceSide = Random.Range(0, 5);

                // Set sprite to upper face of dice from array according to random value
                rend.sprite = diceSides[randomDiceSide];

                // Pause before next itteration
                yield return new WaitForSeconds(0.05f);
            }

            // Assigning final side so you can use this value later in your game
            // for player movement for example
            finalSide2 = randomDiceSide + 1;
            score.score2 = (float)finalSide2;
            // Show final dice value in Console
            Debug.Log(finalSide2);
        }
    }
}
