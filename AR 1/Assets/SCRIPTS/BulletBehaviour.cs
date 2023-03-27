using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{

    public float speed ;
    PlayerMovement player ;
    [SerializeField] GameObject expl;
    public float bulletLife = 3;
    Canvas cs;
    //public RockStats rockPrefab;
    private void Awake()
    {
        cs = FindObjectOfType<Canvas>();
    }
    void FixedUpdate()
    {
        transform.position += transform.right * Time.deltaTime * speed ;

        bulletLife -= Time.deltaTime;

        if(bulletLife <= 0)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Rock")
        {
            cs.GetComponent<score_and_time>().score += 30;
            Instantiate(expl, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            
            Destroy(gameObject);

        }

        else if ( collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}
