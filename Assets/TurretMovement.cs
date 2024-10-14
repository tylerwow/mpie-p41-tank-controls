using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    public float turnSpeed = 75.0f;

    void Update ()
    {
        float rotation = 0.0f;
        if (Input.GetKey (KeyCode.Q))
        {
        rotation = -turnSpeed * Time.deltaTime;
        }
        else if (Input.GetKey (KeyCode.E))
        {
        rotation = turnSpeed * Time.deltaTime;
        }
        Transform t = gameObject.transform;
        t.Rotate (0.0f, rotation, 0.0f);
    }
}
