using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    Animator anim;
    string next;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        anim = GetComponent<Animator>();
        Application.targetFrameRate = 300;
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("p"))
        {
            anim.SetBool("anim", true);
            StartCoroutine(mainmen());
            next = "BlankAR";

        }
        if (CrossPlatformInputManager.GetButtonDown("r"))
        {
            anim.SetBool("anim", true);
            StartCoroutine(mainmen());
            next = "rules";

        }
        if (CrossPlatformInputManager.GetButtonDown("q"))
        {
            Application.Quit();

        }

    }
    IEnumerator mainmen()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(next);

    }
}
