using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerMovement : MonoBehaviour
{
    public float groundSpeed;
    public float airSpeed;
    public float jumpstrength;
    public float walkDeceleration;
    public BulletBehaviour bulletPrefab;
    public Transform launchOffset;
    public float timeBetweenShots;
    

    private Rigidbody2D rb;
    private bool isJumping = true;
    bool abletoshoot = true;
    [SerializeField] DynamicJoystick dj;

    //jumping part:
    public float buttonTime = 0.5f;
    public float jumpHeight = 5;
    public float cancelRate = 100;
    float jumpTime;
    bool jumping;
    bool jumpCancelled;
    float walkInput;
    Animator anim;
    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        Application.targetFrameRate = 300;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        walkInput = dj.Horizontal;
        anim.SetFloat("x", walkInput);
        if (CrossPlatformInputManager.GetButtonDown("shoot"))
        {
            if (abletoshoot)
            {
                Debug.Log("shoot");
                Instantiate(bulletPrefab, launchOffset.position, transform.rotation);
                abletoshoot = false;
                StartCoroutine(timer());
            }


        }
    }
        /*if (CrossPlatformInputManager.GetButtonDown("jump") && !isJumping)
        {
            anim.SetBool("anim", false);
            float jumpForce = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * rb.gravityScale));
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jumping = true;
            jumpCancelled = false;
            jumpTime = 0;
        }

        if (jumping)
        {
            jumpTime += Time.deltaTime;
            if (CrossPlatformInputManager.GetButtonUp("jump"))
            {
                jumpCancelled = true;
            }
            if (rb.velocity.y < 0)
            {
                jumping = false;
            }
            if (jumpTime > buttonTime)
            {
                jumping = false;
            }

        }
    }*/
        private void FixedUpdate()
    {

        //float walkInput = Input.GetAxisRaw("Horizontal");
        
        
        float speed = isJumping ? airSpeed : groundSpeed;
        
        if ( walkInput != 0 )
        {
            anim.SetBool("anim", true);
            rb.velocity = new Vector2(walkInput * speed, rb.velocity.y);
        }
        else
        {
            anim.SetBool("anim", false);
            if ( rb.velocity.x != 0 )
            {
                rb.AddForce( new Vector2(-rb.velocity.x * walkDeceleration, 0 ) );
            }
        }








         if ( !isJumping && CrossPlatformInputManager.GetButton("jump"))
         {
             rb.AddForce( new Vector2(0,  jumpstrength) , ForceMode2D.Impulse);
         }
        /*if (jumpCancelled && jumping && rb.velocity.y > 0)
        {
            rb.AddForce(Vector2.down * cancelRate);
        }*/
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isJumping = true;
        }
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(timeBetweenShots);
        abletoshoot = true;
    }


}

