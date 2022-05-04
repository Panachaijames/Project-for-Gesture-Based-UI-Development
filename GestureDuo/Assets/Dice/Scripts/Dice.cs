using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dice
{
    [RequireComponent(typeof(PhysicsController))]
    public class Dice : MonoBehaviour
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

                SoundManager.Toss("toss");
            }
        }

        // Coroutine that rolls the dice
        private IEnumerator RollTheDice()
        {
            // Variable to contain random dice side number.
            // It needs to be assigned. Let it be 0 initially
            int randomDiceSide = 0;
            int finalSide = 0;

            // Loop to switch dice sides ramdomly
            // before final side appears. 20 itterations here.
            for (int i = 0; i <= 20; i++)
            {
                randomDiceSide = Random.Range(0, 5);

                // Set sprite to upper face of dice from array according to random value
                rend.sprite = diceSides[randomDiceSide];

                // Pause before next itteration
                yield return new WaitForSeconds(0.05f);
            }

            // Assigning final side 
            finalSide = randomDiceSide + 1;
            score.score1 = (float)finalSide;
            Debug.Log(finalSide);
        }
    }
}
