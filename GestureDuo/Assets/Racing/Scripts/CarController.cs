using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ambulance
{
    public class CarController : MonoBehaviour
    {
        public float carSpeed;
        //public float minPos;
        public float maxPos = 1.6f;

        Vector3 position;

        public UIManager ui;
        public GameObject GOPanel;
        public AudioManager audio;
        bool currentPlatformAndroid = false;

        void Awake()
        {
            #if UNITY_ANDROID
                currentPlatformAndroid = true;
            #else
                currentPlatformAndroid = false;
            #endif

            audio.carSound.Play();
        }
        // Start is called before the first frame update
        void Start()
        {
           // ui = GetComponent<UIManager>();
            position = transform.position;

            if(currentPlatformAndroid == true)
            {
                Debug.Log("Android");
            }
            else
            {
                Debug.Log("Window");
            }
            
        }

        // Update is called once per frame
        void Update()
        {
            if (currentPlatformAndroid == true)
            {
                //android
            }
            else
            {
                position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
                position.x = Mathf.Clamp(position.x, -1.6f, 1.6f);

                transform.position = position;
            }
            
        }

        void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.tag == "EnemyCar")
            {
                Destroy(gameObject);
                ui.gameOverActivated();
                GOPanel.SetActive(true);
                Time.timeScale = 0;
                audio.carSound.Stop();
            }
        }
    }
}
