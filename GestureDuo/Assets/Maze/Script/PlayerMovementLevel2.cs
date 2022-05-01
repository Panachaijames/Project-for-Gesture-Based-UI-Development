using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MazeTilt
{
    public class PlayerMovementLevel2 : MonoBehaviour
    {
        Rigidbody2D rb;
        float dirx;
        float diry;
        float moveSpeed = 20f;
        public GameManagerLevel2 gameManager;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            dirx = Input.acceleration.x * moveSpeed;
            diry = Input.acceleration.y * moveSpeed;
            transform.position = new Vector2(transform.position.x, transform.position.y);

        }

        void FixedUpdate()
        {
            rb.velocity = new Vector2(dirx, diry);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            gameManager.Victory();
            dirx = 0;
            diry = 0;
        }
    }
}