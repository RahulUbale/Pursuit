using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : MonoBehaviour
{   
    Vehicle vehicle;
    public Vehicle target;
    // Start is called before the first frame update
    void Start()
    {
        vehicle = GetComponent<Vehicle>();
        
    }

    // Update is called once per frame
    void Update()
    {
        vehicle.steering = SteeringBehaviors.CalculatePursue(vehicle, target);
        vehicle.MoveVehicle();
        
    }
}
