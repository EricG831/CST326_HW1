using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input : MonoBehaviour
{
    public LeftPaddle leftP;
    public RightPaddle rightP;
    public Ball ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.UpArrow))
        {
            rightP.speed = 10;
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.DownArrow))
        {
            rightP.speed = -10;
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.W))
        {
            leftP.speed = 10;
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.S))
        {
            leftP.speed = -10;
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.Z))
        {
            leftP.speed = 0;
            rightP.speed = 0;
        }
    }
}
