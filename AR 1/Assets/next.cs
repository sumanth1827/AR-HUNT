using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class next : MonoBehaviour
{
    public float abc = 0f;
    public float t = 10f;
    private float duration = 1f;
    public bool ab = false;
    [SerializeField] private Vector3 endpos,a;
    public GameObject portal;

   
    Coroutine cr,cr2;
    [SerializeField] TMP_Text times;


 
    private void Start()
    {
        
        a = Camera.main.transform.position;
        
    }
    void Update()
    {
       
        
       


        if (ab)
        {

            t += Time.deltaTime;
            Camera.main.transform.position = Vector3.Lerp(a, endpos, t/duration);


        }
       
       
    }
    private void OnTriggerEnter(Collider ci)
    {
        if (ci.tag == "Player")
        {


            
            
            cr = StartCoroutine(timer(ci.gameObject));
            cr2 = StartCoroutine(starter());
        }
    }

    private void OnTriggerExit(Collider ci)
    {
        if(ci.tag == "Player")
        {

            
            
            StopCoroutine(cr);
           
            StopCoroutine(cr2);
            times.enabled = false;
        }
    }

    IEnumerator timer(GameObject ci)
    {
        //anims.SetBool("anim", true);
        yield return new WaitForSeconds(1.5f);

        portal.transform.parent.rotation = Quaternion.Euler(0, 0, 0);
        yield return null;
        ci.transform.position = portal.transform.position;
        
        
        a = Camera.main.transform.position;
        endpos.y = a.y - 19f;
        endpos.x = a.x;
        endpos.z = a.z;
        ab = true;

        
        

    }

    IEnumerator starter()
    {
        times.enabled = true;
        times.text = 3.ToString();
        yield return new WaitForSeconds(0.5f);
        times.text = 2.ToString();
        yield return new WaitForSeconds(0.5f);
        times.text = 1.ToString();
        yield return new WaitForSeconds(0.5f);
        times.text = 0.ToString();



    }





    /*
    private void OnTriggerStay(Collider ci)
    {
        if (ci.tag == "Player")
        {
           
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
                            a = Camera.main.transform.position;
                            endpos.y = a.y - 19f;
                            endpos.x = a.x;
                            endpos.z = a.z;
                            ab = true;
                            ci.transform.position = portal.transform.position;
                            
                        }



                    }

                }

            }
        }
    }*/
}
