using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePrefab : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
