using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillTogglePos : MonoBehaviour
{
    public float rotationMin = -39.3f;
    public float rotationMax = 39.5f;
    private float currentRotation;
    private bool isRotating;

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MiddleCollider")
        {
            if (!isRotating)
            {
                currentRotation = transform.rotation.z;
                if (currentRotation == rotationMin)
                {
                    transform.Rotate(0, 0, rotationMax);
                }
                else
                {
                    transform.Rotate(0, 0, rotationMin);
                }
                isRotating = true;
            }
            else
            {
                isRotating = false;
            }
        }
    }
        
}