using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    [SerializeField] Rigidbody2D m_rigidBody2D;
    [SerializeField] CircleCollider2D m_circleCollider;
    [SerializeField] float movementSpeed = 10;


    private void FixedUpdate()
    {
        CanonBallMovement();
    }

    void CanonBallMovement()
    {
        m_rigidBody2D.velocity = this.transform.right * movementSpeed * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tower"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("CanonBall"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
