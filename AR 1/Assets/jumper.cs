using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{
    private Vector3 direction;
    public float force = 10f;
    void Update()
    {
        direction = transform.TransformDirection(Vector3.up * force);
    }
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(direction, ForceMode.VelocityChange);

        }
    }
}
