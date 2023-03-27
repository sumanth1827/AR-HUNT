using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper2 : MonoBehaviour
{
    public float abc = 0f;
    public float t = 10f;
    private float duration = 1f;
    public bool ab = false;
    [SerializeField] private Vector3 endpos, a;
    public GameObject portal,cams;

    private void Start()
    {
        //a = Camera.main.transform.position;
        endpos = Camera.main.transform.position;
    }
    void Update()
    {
        //Camera.main.transform.position = endpos;
        if (ab)
        {
            //endpos.y = 1f; 
            //Camera.main.transform.position = Vector3.Lerp(new Vector3(Camera.main.transform.position.x, 20f, Camera.main.transform.position.z), new Vector3(Camera.main.transform.position.x, 1f, Camera.main.transform.position.z), t / duration);
        }

    }
    private void OnTriggerStay(Collider ci)
    {
        if (ci.tag == "Player")
        {
            a = Camera.main.transform.position;
            if (Input.touchCount > 0)
            {

                Touch touch = Input.GetTouch(0);

                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, abc));
                Vector3 actualtouchpos = new Vector3(touchPosition.x, touchPosition.y, abc);


                if (touch.phase == TouchPhase.Began)
                {


                    Collider[] touchcollider = Physics.OverlapSphere(actualtouchpos, 0.4f);

                    for (int i = 0; i < touchcollider.Length; i++)
                    {
                        if (touchcollider[i].tag == "Player")
                        {
                            //a = Camera.main.transform.position;
                            //endpos.y = a.y - 19f;
                            //endpos.x = a.x;
                            //endpos.z = a.z;
                            // ab = true;
                            // endpos.y = 1f;
                            cams.transform.position = portal.transform.position;
                            ci.transform.position = portal.transform.position;

                        }



                    }

                }

            }
        }
    }
}
