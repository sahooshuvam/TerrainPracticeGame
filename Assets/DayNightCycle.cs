using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    float minPerSeconds = 60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angleTheFrame =  Time.deltaTime/2 * minPerSeconds;
        transform.RotateAround(transform.position, Vector3.forward, angleTheFrame);
    }
}
