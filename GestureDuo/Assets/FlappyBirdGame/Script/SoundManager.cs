using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    public class SoundManager : MonoBehaviour
    {
        public static AudioClip wingSound;
        public static AudioClip hitSound;
        public static AudioClip pointSound;
        static AudioSource audioSrc;
        // Start is called before the first frame update
        void Start()
        {
            wingSound = Resources.Load<AudioClip>("flap");
            hitSound = Resources.Load<AudioClip>("hit");
            pointSound = Resources.Load<AudioClip>("point");

            audioSrc = GetComponent<AudioSource>();
        }

        public static void PlaySound(string clip)
        {
            switch (clip)
            {
                case "flap":
                    audioSrc.PlayOneShot(wingSound);
                    break;
                case "hit":
                    audioSrc.PlayOneShot(hitSound);
                    break;
                case "point":
                    audioSrc.PlayOneShot(pointSound);
                    break;
            }
        }
    }
}