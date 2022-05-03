using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ambulance
{
    public class EnemyCar : MonoBehaviour
    {
        public float speed = 8f;
        float timer = 0;
        float counter = 0;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            /*if(timer > (float)0.2)
            {
                counter += (float)0.1;
            }*/
            transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
        }
    }
}
