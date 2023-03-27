using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class score12 : MonoBehaviour
{
    public float score1;
    //public Text text1;
    private TMP_Text text1;
    public bool abc = true;
    public int n;
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        score1 = 0;
        text1 = GetComponent<TMP_Text>();
        abc = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (abc)
        {
            score1 += n* Time.deltaTime;
          
            if(score1 >500)
            {
                anim.SetBool("anim", true);
                StartCoroutine(mainmen());
            }
            text1.text = score1.ToString("0") + " meters";
        }
    }
    IEnumerator mainmen()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("BlankAR");

    }
}
