using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class MyPrefabInstantiator2 : DefaultObserverEventHandler
{
    public static bool third = true;
    [SerializeField] string level_name;

    protected override void OnTrackingFound()
    {
        Debug.Log("Target Found");
        if(third)
        {
            third = false;
            SceneManager.LoadScene(level_name);
            
            
        }

        // Instantiate the model prefab only if it hasn't been instantiated yet


        base.OnTrackingFound();
    }

}
