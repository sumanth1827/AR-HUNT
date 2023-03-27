using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class MyPrefabInstantiator1 : DefaultObserverEventHandler
{
    public static bool second = true;
    [SerializeField] string level_name;

    protected override void OnTrackingFound()
    {
        Debug.Log("Target Found");
        if(second)
        {
            second = false;
            SceneManager.LoadScene(level_name);
            
            
        }

        // Instantiate the model prefab only if it hasn't been instantiated yet


        base.OnTrackingFound();
    }

}
