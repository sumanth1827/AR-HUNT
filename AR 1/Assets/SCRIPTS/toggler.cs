using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggler : MonoBehaviour
{
    public float abc = 0f;
    public gyro g;

    // Start is called before the first frame update
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, abc));
            Vector3 actualtouchpos = new Vector3(touchPosition.x, touchPosition.y, abc);
            
            Collider[] touchcollider = Physics.OverlapSphere(actualtouchpos, 0.4f);
            
                          
                //Gizmos.DrawSphere(touchPosition, 0.4f);
               
                for (int i = 0; i < touchcollider.Length; i++)
                {
                  
                    if (touchcollider[i].tag == "button2")
                    {
                        if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary)
                        {
                        g.gyro_on = true;
                            //Input.gyro.enabled = true;
                        }
                        else if (touch.phase == TouchPhase.Ended)
                        {
                        g.gyro_on = false;
                       
                        }
                        else
                        {
                        g.gyro_on = false;
                        }

                    }


                }

            
      
        }
    }
   
}

