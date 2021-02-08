using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public string leftS;
    public string rightS;
    public int leftPScore = 0;
    public int rightPScore = 0;
    public Ball ball;
    private Rigidbody rb;
    public int speed = 15;
    public int amplify = 1;

    void Start()
    {
        rb = ball.gameObject.GetComponent<Rigidbody>();
    }

    void leftR()
    {
        ball.transform.position = new Vector3();
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;
      
        rb.velocity = new Vector3(10f, 10f, 15f);
    }

    void rightR()
    {
        ball.transform.position = new Vector3();
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector3(-10f, -10f, -15f);
    }


    void OnCollisionEnter(Collision collision)
    {
        if (this.name == "LeftGoal")
        {
            Debug.Log("RightPlayer Scored");
            rightPScore++;
            rightS = rightPScore.ToString();
            leftR();
        }
        
        if (this.name == "RightGoal")
        {
            Debug.Log("LeftPlayer Scored");
            leftPScore++;
            leftS = leftPScore.ToString();
            rightR();
        }
        //Debug.Log($"{this.name} collided with the {collision.gameObject.name}");
    }

    // Debug.Log($"{other.name} passed through my collider - {this.name}");
}


