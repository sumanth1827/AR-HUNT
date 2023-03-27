using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class imagerecog : MonoBehaviour
{
    private ARTrackedImageManager test;
    [SerializeField] GameObject spawn;
    // Start is called before the first frame update
    private void Awake()
    {
        test = FindObjectOfType<ARTrackedImageManager>(); 
    }
    private void OnEnable()
    {
        test.trackedImagesChanged += onimagechange;
    }
    void onimagechange(ARTrackedImagesChangedEventArgs args)
    {
        foreach(var tracked_image in args.added)
        {
            Instantiate(spawn, tracked_image.transform.position,tracked_image.transform.rotation);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
