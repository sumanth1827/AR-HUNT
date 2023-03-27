using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 5f;
    Canvas cs;
    bool oncehit = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cs = FindObjectOfType<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-speed, 0f);
        transform.Rotate(new Vector3(0f,0f,1f), 2f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "rockboundary")
        {
            cs.GetComponent<score_and_time>().score -= 20;
            Destroy(gameObject);
        }
        if(collision.tag == "Player" && collision.GetType() == typeof(CapsuleCollider2D) && oncehit)
        {
            
            collision.GetComponent<health>().damage();
            collision.GetComponent<health>().healths -= 1;
            oncehit = false;
            
            

        }
    }

}
