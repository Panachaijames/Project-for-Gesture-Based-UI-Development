using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    public class FlyLittleBird : MonoBehaviour
    {
        public GameManager gameManager;
        public float velocity = 1;
        private Rigidbody2D rb;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                //Jump
                rb.velocity = Vector2.up * velocity;

                SoundManager.PlaySound("wing");
            }
            
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            SoundManager.PlaySound("hit");
            Destroy(gameObject);
            gameManager.GameOver();
        }
    }
}