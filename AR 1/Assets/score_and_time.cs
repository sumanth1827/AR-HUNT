using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class score_and_time : MonoBehaviour
{
    float timer = 60f;
    public int score = 0;
    [SerializeField] Slider s;
    [SerializeField] TMP_Text scores;
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scores.text = score.ToString();
        timer -= Time.deltaTime;
        if(timer >= 0f)
        {
            s.value = timer;
        }
        if(timer < 0f)
        {
            anim.SetBool("anim", true);
            
            StartCoroutine(mainmen());
            //finish game move to next scene
        }
        IEnumerator mainmen()
        {
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene("BlankAR");
            

        }
    }
}
