using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SideSpawn { Right, Left, Up, Down }

public class Beat : MonoBehaviour
{
    public SideSpawn mySide;
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
            Transform objectiveTransform = null;
            switch (mySide)
            {
                case SideSpawn.Right:
                    objectiveTransform = GameObject.Find("Objective Right").GetComponent<Transform>();
                    break;
                case SideSpawn.Left:
                    objectiveTransform = GameObject.Find("Objective Left").GetComponent<Transform>();
                    break;
                case SideSpawn.Up:
                    objectiveTransform = GameObject.Find("Objective Up").GetComponent<Transform>();
                    break;
                case SideSpawn.Down:
                    objectiveTransform = GameObject.Find("Objective Down").GetComponent<Transform>();
                    break;
            }
            if( (objectiveTransform.position - this.transform.position).magnitude <= 0.5f)
            {
                print("Perfect");
            }
            else if((1f >= (objectiveTransform.position - this.transform.position).magnitude) && ((objectiveTransform.position - this.transform.position).magnitude > 0.5f))
            {
                print("Good");
            }
            else
            {
                print("Bad");
            }
            print((objectiveTransform.position - this.transform.position).magnitude);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
