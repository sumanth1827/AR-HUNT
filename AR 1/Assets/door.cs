using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    bool ws = true;
    float ts = 0;
    float elapsed = 50f;
    Animator anims;
    // Start is called before the first frame update
    void Start()
    {
        anims = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ws)
        {



            elapsed += Time.deltaTime;
            ts = Mathf.Lerp(ts, 0, elapsed / 1500f);
            anims.SetFloat("test", ts);
        }
        else if (!ws)
        {


            elapsed += Time.deltaTime;
            ts = Mathf.Lerp(ts, 1, elapsed / 1500f);
            anims.SetFloat("test", ts);
        }
    }
    private void OnTriggerEnter(Collider ci)
    {
        if(ci.tag == "Player")
        {
            anims.SetBool("anim", true);
            
            ws = true;
        }

    }
    private void OnTriggerExit(Collider ci)
    {
        if(ci.tag =="Player")
        {
            ws = false;
            
        }
    }
}
