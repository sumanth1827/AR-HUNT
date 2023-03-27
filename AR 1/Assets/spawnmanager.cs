using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class spawnmanager : MonoBehaviour
{
    [SerializeField] ARRaycastManager raymanager;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    [SerializeField] GameObject spawn;
    Camera arcam;
    GameObject spawned;

   // Start is called before the first frame update
    void Start()
    {
        spawned = null;
        arcam = GameObject.Find("AR Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount ==0)
        {
            return;
        }
        RaycastHit hit;
        Ray ray = arcam.ScreenPointToRay(Input.GetTouch(0).position);
        if(raymanager.Raycast(Input.GetTouch(0).position, hits))
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began && spawned == null)
            {
                if(Physics.Raycast(ray, out hit))
                {
                    if(hit.collider.gameObject.tag == "Spawnable")
                    {
                        spawned = hit.collider.gameObject;
                    }
                    else
                    {
                        spawner(hits[0].pose.position);
                    }
                }
            }
            else if(Input.GetTouch(0).phase == TouchPhase.Moved && spawned != null)
            {
                spawned.transform.position = hits[0].pose.position;
            }
            if(Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                spawned = null;
            }
        }
    }
    void spawner(Vector3 spawnpos)
    {
        spawned = Instantiate(spawn, spawnpos, Quaternion.identity);
    }
}
