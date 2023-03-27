using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class score : MonoBehaviour
{
    public int level;
    public float scores;
    public int deaths=0;
    public static int actdeath;
    [SerializeField] TMP_Text lvl, sco, dth;
    [SerializeField] Image a1, a2, a3;
    static int totalscore;
    public int currscore;
    bool changescore1 = true, changescore2 = true, changescore3 = true;
    [SerializeField] Slider[] s;
   void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex + 1;
        lvl.text = level.ToString();
        scores = 300f;
    }
    private void Awake()
    {
        deaths = actdeath;
        currscore = totalscore;
        currscore += 90;
    }
    // Update is called once per frame
    void Update()
    {
        actdeath = deaths;
        totalscore = currscore;
    dth.text = deaths.ToString();
        scores -= Time.deltaTime;
        sco.text = currscore.ToString();
        s[0].value = scores;
        s[1].value = scores;
        s[2].value = scores;
        if (scores<200 && changescore1)
        {
            Destroy(a3);
            currscore -= 30;
            changescore1 = false;

        }

        if(scores<100 && changescore2)
        {
            Destroy(a2);
            currscore -= 30;
            changescore2 = false;
        }
        if(scores <25 && changescore3)
        {
            Destroy(a1);
            currscore -= 15;
            changescore3 = false;
        }
}
}
