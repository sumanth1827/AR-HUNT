using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner2 : MonoBehaviour
{
    [SerializeField] GameObject rock;
    float t = 1f;
    float duration = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timer());
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > duration)
        {
            

            
            Instantiate(rock, new Vector2(transform.position.x, Random.Range(-2.8f, 1.5f)), transform.rotation);
            t = 0f;
           
        }
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(5f);
        duration = 2.5f;
        yield return new WaitForSeconds(5f);
        duration = 2f;
        yield return new WaitForSeconds(5f);
        duration = 1.5f;


    }
}
