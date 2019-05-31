using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {
    public string Horizontal1; public string Vertical1;


    public Vector2 move;
    public Vector2 velocity; // in metres per second
    public float maxSpeed = 5.0f; // in metres per second
    public float acceleration = 5.0f; // in metres/second/second
    public float brake = 5.0f; // in metres/second/second
    public float turnSpeed = 30.0f; // in degrees/second
    private float speed = 0.0f;    // in metres/second
                                   // Update is called once per frame
    void Update()
    {
        // the horizontal axis controls the turn
        float turn = Input.GetAxis("Horizontal");
        // turn the car
        transform.Rotate(0, 0, turn * turnSpeed * Time.deltaTime);
        // the vertical axis controls acceleration fwd/back
        float forwards = Input.GetAxis("Vertical");
        if (forwards > 0)
        {
            // accelerate forwards
            speed = speed + acceleration * Time.deltaTime;
        }
        else if (forwards < 0)
        {
            // accelerate backwards
            speed = speed - acceleration * Time.deltaTime;
        }
        else
        {
            // braking
            if (speed > 0)
            {
                speed = speed - brake * Time.deltaTime;
            }
            else
            {
                speed = speed + brake * Time.deltaTime;
            }
        }

        // clamp the speed
        speed = Mathf.Clamp(speed, -maxSpeed, maxSpeed);
        // compute a vector in the up direction of length speed
        Vector2 velocity = Vector2.up * speed;
        // move the object
        transform.Translate(velocity * Time.deltaTime, Space.Self);
    }
}
