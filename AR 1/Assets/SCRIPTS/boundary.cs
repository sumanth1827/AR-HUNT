using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boundary : MonoBehaviour
{
    score sc;
    [SerializeField] Transform portal;
    private void Start()
    {
        sc = GameObject.FindWithTag("score").GetComponent<score>();
    }
    private void OnTriggerEnter(Collider ci)
    {
        if (ci.tag == "Player")
        {
            ci.transform.position = portal.position;
            sc.deaths++;
            sc.currscore -= 1;
        }
    }

}
