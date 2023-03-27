using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trap : MonoBehaviour
{
    [SerializeField] Transform portal;
    [SerializeField] GameObject anim;
    score sc;
    // Start is called before the first frame update
    void Start()
    {
        sc = GameObject.FindWithTag("score").GetComponent<score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision ci)
    {
        if(ci.gameObject.tag == "Player")
        {

            StartCoroutine(delay(ci.gameObject));
            sc.deaths++;
            sc.currscore -= 2;

        }
    }
    IEnumerator delay(GameObject ci)
    {
        anim.SetActive(true);
        yield return null;
        ci.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        transform.parent.rotation = Quaternion.Euler(0, 0, 0);
        

        yield return new WaitForSeconds(0.3f);
        anim.SetActive(false);
        ci.transform.position = portal.position;
        ci.SetActive(true);
    }

}
