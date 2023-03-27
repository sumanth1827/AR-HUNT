using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("working");
    }
    private void OnTriggerEnter(Collider ci)
    {
        if(ci.name == "key")
        {

            anim.SetBool("anim", true);
            
        }
    }

}
