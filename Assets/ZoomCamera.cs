using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    Camera cam;
    public float defaultView;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("ZoomView"))
        {
            cam.fieldOfView = 30f;
        }
        else
        {
            cam.fieldOfView = defaultView;
        }
    }
}
