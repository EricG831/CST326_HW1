using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int amplify = 1;
    private bool groundHit = false;
    public int speed = 15;
    private Vector3 impactValue = Vector3.zero;

    void Start()
    {
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 5f);
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        speed++;
        groundHit = true;

    }

    void FixedUpdate()
    {
        if (groundHit) HitGround();
        impactValue = GetComponent<Rigidbody>().velocity;
    }

    private void HitGround()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.AddForce((Vector3.up * amplify * speed), ForceMode.Impulse);
        groundHit = false;
    }
}

