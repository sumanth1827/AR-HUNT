using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyro : MonoBehaviour
{
    
    private Quaternion startpos;
    public bool gyro_on = false;

    // Start is called before the first frame update
    void Start()
    {
        //Input.gyro.enabled = false;
        //startpos = transform.rotation;
    }

    // Update is called once per frame
    /*void Update()
    {
        if (gyro_on)
        {
            Input.gyro.enabled = true;
            transform.Rotate(-Input.gyro.rotationRate.x, -Input.gyro.rotationRate.y, 0);
        }
        else if(!gyro_on)
        {
            transform.rotation = startpos;
            Input.gyro.enabled = false;
        }
       
    }*/
}
