using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private float time = 0;
    [SerializeField] public int score = 0;
    public TextMeshProUGUI scoreTxt;
    public GameObject panel;
    public GameObject spawn;
    [SerializeField] Animator anim;

    private void Awake()
    {
        instance = this;
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        time += Time.deltaTime;
        score = (int)time;
        scoreTxt.text = score.ToString();
        if(score >= 100f)
        {
            anim.SetBool("anim", true);
            StartCoroutine(mainmen());
        }
    
    }
    IEnumerator mainmen()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("BlankAR");


    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        score = 0;
    }
}
