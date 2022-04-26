using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    bool wasJustClicked = true;
    bool canMove;
    Vector2 playerSize;
    private Touch touch;
    private Vector2 beginTouchPosition, endTouchPosition;

    Rigidbody2D rb;

    public Transform BoundaryHolder;

    Boundary playerBoundary;


    // Use this for initialization
    void Start()
    {
        playerSize = GetComponent<SpriteRenderer>().bounds.extents;
        rb = GetComponent<Rigidbody2D>();

        playerBoundary = new Boundary(BoundaryHolder.GetChild(0).position.y,
            BoundaryHolder.GetChild(1).position.y,
            BoundaryHolder.GetChild(2).position.x,
            BoundaryHolder.GetChild(3).position.x);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) || Input.touchCount > 0)
        {
            //touch = Input.GetTouch(0);

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
            //Vector2 pos = touch.position;

            if (wasJustClicked)
            {
                wasJustClicked = false;
               

                /*if ((pos.x >= transform.position.x && pos.x < transform.position.x + playerSize.x ||
                pos.x <= transform.position.x && pos.x > transform.position.x - playerSize.x) &&
                (pos.y >= transform.position.y && pos.y < transform.position.y + playerSize.y ||
                pos.y <= transform.position.y && pos.y > transform.position.y - playerSize.y))
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }*/

                if ((mousePos.x >= transform.position.x && mousePos.x < transform.position.x + playerSize.x ||
               mousePos.x <= transform.position.x && mousePos.x > transform.position.x - playerSize.x) &&
               (mousePos.y >= transform.position.y && mousePos.y < transform.position.y + playerSize.y ||
               mousePos.y <= transform.position.y && mousePos.y > transform.position.y - playerSize.y))
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            }

            if (canMove)
            {
                Vector2 clampedMousePos = new Vector2(Mathf.Clamp(mousePos.x, playerBoundary.Left,
                                                                 playerBoundary.Right),
                                                     Mathf.Clamp(mousePos.y, playerBoundary.Down,
                                                                 playerBoundary.Up));
                // rb.MovePosition(pos);
                rb.MovePosition(clampedMousePos);
            }
                    
        }
        else
        {
            wasJustClicked = true;
        }
    }
}