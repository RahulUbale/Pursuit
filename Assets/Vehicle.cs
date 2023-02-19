using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [HideInInspector]
    public Vector3 velocity;
    [HideInInspector]
    public Vector3 steering;

    public float mass = 1;
    public float maxSpeed = 5;
    public float minSpeed = 5;

    public float maxSteering = .2f;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveVehicle()
    {
        steering = Vector3.ClampMagnitude(steering, maxSteering);

        velocity += steering;

        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        this.transform.position += velocity * Time.deltaTime;
    }
}
