using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D player;
    public GameManager gameManager;
    Vector3 playerPos;

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        Time.timeScale = 0f;
    }
    private void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            gameManager.panel.SetActive(false);
            gameManager.spawn.SetActive(true);
            Time.timeScale = 1f;
            Vector3 mousePos =  Input.mousePosition;
            playerPos = Camera.main.ScreenToWorldPoint(mousePos);
            playerPos.z = 0;
         
            player.position = playerPos;

            
        }
        if (Input.GetMouseButtonUp(0))
        {
            gameManager.Restart();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameManager.instance.Restart();
            Debug.Log("Collision detected");
        }
    }
}
