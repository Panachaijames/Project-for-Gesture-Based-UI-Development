using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    public class PipeMove : MonoBehaviour
    {
        public float speed;
        private float counter;
        private float sot = 1;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            counter+= Time.deltaTime;
            if (counter >= 3)
            {
                sot += (float)0.1;
                counter = 0;
            }

            transform.position += Vector3.left * speed * Time.deltaTime * sot;

        }
    }
}