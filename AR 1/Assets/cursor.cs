using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class cursor : MonoBehaviour
{
    public GameObject cursorobj;
    public GameObject objtoplace;
    public ARRaycastManager manage;
    public bool useCursor = true;
    // Start is called before the first frame update
    void Start()
    {
        cursorobj.SetActive(useCursor);
    }

    // Update is called once per frame
    void Update()
    {
        if(useCursor)
        {
            Vector2 screenposition = Camera.main.ViewportToScreenPoint(new Vector2(0.5f, 0.5f));
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            manage.Raycast(screenposition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
            if (hits.Count > 0)
            {
                transform.position = hits[0].pose.position;
                transform.rotation = hits[0].pose.rotation;
            }
        }
    }
    void Updatecursor()
    {
       
    }
}
