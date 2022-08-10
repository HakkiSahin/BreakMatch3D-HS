using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteerRoad : MonoBehaviour
{

    private float sceneWidth;
    private Vector3 pressPoint;
    private Quaternion startRot;
    
    void Start()
    {
        sceneWidth = Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pressPoint=Input.mousePosition;
            startRot = transform.rotation;
        }
        else if (Input.GetMouseButton(0))
        {
            float currentMousePos = (Input.mousePosition - pressPoint).x;
            transform.rotation = startRot * Quaternion.Euler(Vector3.forward * (currentMousePos / sceneWidth) * -360);
        }
    }
}
