using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{
    GameObject rocket;

    // Start is called before the first frame update
    void Start()
    {
        rocket = GameObject.Find("Rocket");
    }
    

    // Update is called once per frame
    void Update()
    {
        var rocketPosition = rocket.transform.position;
        int minDistance = 1;
        if (VArithmetics.GetDistance(transform.position, rocketPosition) > minDistance)
        {
            transform.Translate(VArithmetics.GetVelocity(transform.position, rocket.transform.position, 1));
        }
        Debug.Log(VArithmetics.GetDistance(transform.position, rocket.transform.position));
        
    }
}
