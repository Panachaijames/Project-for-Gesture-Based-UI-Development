using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dice
{
    public class SoundManager : MonoBehaviour
    {
        public static AudioClip tossSound;
        static AudioSource audioSrc;
        // Start is called before the first frame update
        void Start()
        {
            tossSound = Resources.Load<AudioClip>("toss");

            audioSrc = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public static void Toss(string clip)
        {
            switch (clip)
            {
                case "toss":
                    audioSrc.PlayOneShot(tossSound);
                    break;
            }
        }
    }
}
