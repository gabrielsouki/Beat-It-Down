using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : MonoBehaviour
{
    [SerializeField] Rigidbody2D m_rigidBody2D;
    [SerializeField] CircleCollider2D m_circleCollider;
    [SerializeField] float movementSpeed = 10;
    [SerializeField] float timeToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }

    private void FixedUpdate()
    {
        CanonBallMovement();
    }

    void CanonBallMovement()
    {
        m_rigidBody2D.velocity = this.transform.right * movementSpeed * Time.fixedDeltaTime;
    }
}
