using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    // Start is called before the first frame update
    Vehicle vehicle;
    public  Vector3 direction;
    void Start()
    {

        vehicle = GetComponent<Vehicle>();
        
    }

    // Update is called once per frame
    void Update()
    {
        vehicle.velocity = direction.normalized * vehicle.maxSpeed;
        vehicle.MoveVehicle();

        
    }
}
