using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ambulance
{
    public class CarSpawner : MonoBehaviour
    {
        public GameObject[] cars;
        public float maxPos = 1.6f;
        public float delayTimer = 0.6f;
        float timer;
        int carNo;

        // Start is called before the first frame update
        void Start()
        {
            timer = delayTimer;
        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                Vector3 carPos = new Vector3(Random.Range(-1.6f,1.6f), transform.position.y, transform.position.z);

                carNo = Random.Range(0, 5);
                Instantiate(cars[carNo], carPos, transform.rotation);
                timer = delayTimer;
            }

           
        }
    }
}
