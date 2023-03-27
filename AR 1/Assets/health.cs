using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public int healths = 5;
    PlayerMovement pl;
    Animator anim;
    [SerializeField] GameObject panels;
    [SerializeField] GameObject[] lives;
    // Start is called before the first frame update
    void Start()
    {
        pl = GetComponent<PlayerMovement>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(healths);
        if(healths <=0)
        {
            anim.SetBool("die", true);
            pl.enabled = false;
            StartCoroutine(canvase());
        }
    }
    public void damage()
    {
        Destroy(lives[healths-1]);
        
        
        StartCoroutine(damages());
    }
    IEnumerator damages()
    {

       
        anim.SetBool("dmg", true);
        
        yield return new WaitForSeconds(0.5f);
        
        
        anim.SetBool("dmg", false);
    }
    IEnumerator canvase()
    {
        yield return new WaitForSeconds(0.35f);
        panels.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
