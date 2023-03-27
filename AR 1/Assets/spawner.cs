using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject ball;
    float  t=2f;
    float gap = 20f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update()
    {
        
        t += Time.deltaTime;
        if(t>gap)
        {

            Instantiate(ball, new Vector2(Random.Range(-9f, 9f), transform.position.y ), transform.rotation);

            t = 0f;
        }
    }
    IEnumerator timer()
    {
        
        yield return new WaitForSeconds(25f);
        gap = 1.5f;
        yield return new WaitForSeconds(15f);
        gap = 1f;
        yield return new WaitForSeconds(15f);
        gap = 0.5f;



    }
    
}
