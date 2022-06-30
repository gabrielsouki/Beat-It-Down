using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] GameObject canonBall;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject ball = Instantiate(canonBall, this.transform);
            ball.transform.right = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject ball = Instantiate(canonBall, this.transform);
            ball.transform.right = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject ball = Instantiate(canonBall, this.transform);
            ball.transform.right = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject ball = Instantiate(canonBall, this.transform);
            ball.transform.right = Vector2.down;
        }
    }
}
