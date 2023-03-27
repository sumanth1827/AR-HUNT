using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class press : MonoBehaviour
{
    
    
    Coroutine  cr2;
    [SerializeField] TMP_Text times;

    private void OnTriggerEnter(Collider ci)
    {
        if (ci.tag == "Player")
        {
           
            cr2 = StartCoroutine(starter());
        }
    }

    private void OnTriggerExit(Collider ci)
    {
        if (ci.tag == "Player")
        {
           
            StopCoroutine(cr2);
            times.enabled = false;
        }
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
        yield return null;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);



    }
}
