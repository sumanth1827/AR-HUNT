using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ar_test : MonoBehaviour
{
    private float dist;
    private bool dragging = false;
    private Vector3 offset;
    private Transform toDrag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v3;
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    

                    
                    
                    if (hit.collider.tag == "movable")
                    {


                        toDrag = hit.transform;
                        dist = hit.transform.position.z - Camera.main.transform.position.z;
                        v3 = new Vector3(touch.position.x, touch.position.y, dist);
                        v3 = Camera.main.ScreenToWorldPoint(v3);
                        offset = toDrag.position - v3;
                        dragging = true;
                    }
                }
            }
            if (dragging && touch.phase == TouchPhase.Moved)
            {
                v3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
                v3 = Camera.main.ScreenToWorldPoint(v3);
                toDrag.position = v3 + offset;
            }
            if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
            {
                dragging = false;
            }


        }
    }
}
