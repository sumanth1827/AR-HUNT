using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    Rigidbody rb;
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.right * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "block")
        {
            speed *= -1;
            speed = 0.01f;
        }
    }
}
