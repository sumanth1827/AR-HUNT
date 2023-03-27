using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    public float rotateSpeed = 100f;
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, -(rotateSpeed * Time.deltaTime));
    }
}
