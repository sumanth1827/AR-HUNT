using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public Rigidbody mains;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchposition = Camera.main.ScreenToWorldPoint(touch.position);
            if(touch.phase == TouchPhase.Began)
            {
                if(touch.position.x > ((Screen.width)/2) )
                {
                    mains.AddTorque(0,0,15);
                }
                else
                {
                    mains.AddTorque(0, 0, -15);
                }
            }
            if (touch.phase == TouchPhase.Moved)
            {

            }
            if (touch.phase == TouchPhase.Ended)
            {

            }
        }
    }
}
