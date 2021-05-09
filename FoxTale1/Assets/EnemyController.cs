using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float enemyMoveSpeed;
    public Transform rightPoint, leftPoint;
    private bool movingRight;
    private Rigidbody2D rb;
    public SpriteRenderer sr;
    public float moveTime, waitTime;
    private float moveCount, waitCount;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rightPoint.parent = null;
        leftPoint.parent = null;
        movingRight = true;
        moveCount = Random.Range(moveTime * 0.75f, moveTime * 1.25f);
    }

    // Update is called once per frame
    void Update()
    {
        if (moveCount > 0)
        {
            moveCount -= Time.deltaTime;
            if (movingRight)
            {
                rb.velocity = new Vector2(enemyMoveSpeed, rb.velocity.y);
                sr.flipX = true;
                if (transform.position.x > rightPoint.position.x)
                {
                    movingRight = false;
                }
            }
            else
            {
                rb.velocity = new Vector2(-enemyMoveSpeed, rb.velocity.y);
                sr.flipX = false;
                if (transform.position.x < leftPoint.position.x)
                {
                    movingRight = true;
                }
            }

            if (moveCount < 0.01)
            {
                waitCount = Random.Range(waitTime * 0.75f, waitTime * 1.25f);
            }


        }

        else if (waitCount >= 0)
        {
            waitCount -= Time.deltaTime;
            rb.velocity = new Vector2(0, rb.velocity.y);
            if (waitCount < 0)
            {
                moveCount = Random.Range(moveTime * 0.75f, moveTime * 1.25f); ;
            }

        }
        
        
    }
}
