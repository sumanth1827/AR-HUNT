using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contro : MonoBehaviour
{
    public float rotateSpeed = 10f;

    void Start()
    {
        Application.targetFrameRate = 300;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    private void Update()
    {

    }
    void FixedUpdate()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {


                if (touch.position.x > ((Screen.width) / 2))
                {
                    
                    transform.Rotate(Vector3.forward, -(rotateSpeed * Time.deltaTime));
                    
                   
                }
                else
                {
                    
                    transform.Rotate(Vector3.forward, (rotateSpeed * Time.deltaTime));
                    
                }
            }
            if (touch.phase == TouchPhase.Stationary)
            {
                if (touch.position.x > ((Screen.width) / 2))
                {
                    
                    transform.Rotate(Vector3.forward, -(rotateSpeed * Time.deltaTime));
                    
                }
                else
                {
                    
                    transform.Rotate(Vector3.forward, (rotateSpeed * Time.deltaTime));
                    
                }
            }
            if (touch.phase == TouchPhase.Moved)
            {
                if (touch.position.x > ((Screen.width) / 2))
                {
                    
                    transform.Rotate(Vector3.forward, -(rotateSpeed * Time.deltaTime));
                    
                }
                else
                {
                    
                    transform.Rotate(Vector3.forward, (rotateSpeed * Time.deltaTime));
                    
                }
            }
           
        }
    }
}
