using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class MyPrefabInstantiator3 : DefaultObserverEventHandler
{
    public static bool fourth = true;
    [SerializeField] string level_name;

    protected override void OnTrackingFound()
    {
        Debug.Log("Target Found");
        if(fourth)
        {
            fourth = false;
            SceneManager.LoadScene(level_name);
            
            
        }

        // Instantiate the model prefab only if it hasn't been instantiated yet


        base.OnTrackingFound();
    }

}
