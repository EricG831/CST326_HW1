using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddle : MonoBehaviour
{
    public int speed = 0;
   
    // Update is called once per frame
    void Update()
    {
        // modify y value(up and down)
        if(transform.position.y > -8 && transform.position.y < 8)
        transform.position = transform.position + new Vector3(0, 0, (Time.deltaTime * speed));

    }
}