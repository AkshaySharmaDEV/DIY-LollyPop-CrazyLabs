using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDrill : MonoBehaviour
{

    public float rotationSpeed;
    public bool reverseDirection;

    void Update()
    {
        // If reverse direction is true, rotate in opposite direction
        if (reverseDirection)
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }
        // Otherwise, rotate in normal direction
        else
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }
}
