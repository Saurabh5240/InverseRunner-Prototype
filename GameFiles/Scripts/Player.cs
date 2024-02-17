using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float force = 100f;
    private bool jump = false;
    public GameObject player2;
    public bool gameOver;
    public TextMeshProUGUI gameOverText;
    public Button restart;
    public TextMeshProUGUI coinsText;
    public RawImage heart1;
    public RawImage heart2;
    public RawImage heart3;
    private int hitCount = 0;
    public int coins = 0;


    


    public GameObject bullet;
    // Start is called before the first frame update

    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
        playerRb = GetComponent<Rigidbody2D>();

        coinsText.text = "Coins: " + coins;
    }

    void Update()
    {
        if (!gameOver)
        {
            if (Input.GetMouseButtonDown(0) && jump)
            {
                Jump();
                MovePlayer2();
            }



            SpawnBullets();

            //Hearts
            if (hitCount == 1)
                heart1.gameObject.SetActive(false);
            if (hitCount == 2)
                heart2.gameObject.SetActive(false);
            if (hitCount == 3)
            {
                heart3.gameObject.SetActive(false);
                gameOver = true;
                gameOverText.gameObject.SetActive(true);
                restart.gameObject.SetActive(true);

            }



        }
        
           

        
        
    }

    void Jump()
    {
        
        playerRb.velocity = new Vector2(0, force);
        jump = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            jump = true;
        
        }

        if (collision.gameObject.CompareTag("Obstacle") )
        {
            hitCount += 1;
            transform.position = new Vector2(-7.22f,-1f);
            player2.transform.position = new Vector2(-7.22f,1f);
            
            
        
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            hitCount += 1;

        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            coins += 2;
            Destroy(collision.gameObject);
            coinsText.text = "Coins: " + coins;

        }


    }

    void MovePlayer2()
    {
        //float yPos = transform.position.y;
        //player2.transform.position = new Vector2(transform.position.x, -yPos);
        player2.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -force);


    }

    void SpawnBullets()
    {
        Vector2 spawnPos = new Vector2(transform.position.x + 0.7f, transform.position.y + 0.13f);
        Vector2 spawnPos2 = new Vector2(player2.transform.position.x+0.7f , player2.transform.position.y);
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(bullet, spawnPos, bullet.transform.rotation);
            Instantiate(bullet, spawnPos2, bullet.transform.rotation);
        }

    }

    void CoinsText()
    {
        
        

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOver = false;


    }


}
