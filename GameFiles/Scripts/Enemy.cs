using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 4.0f;
    private float xstartPos;
    private float hitPoint = 0;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        xstartPos = transform.position.x;
        player = GameObject.Find("Player1").GetComponent<Player>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player.gameOver)
        {
            transform.Translate(Vector2.up * -speed * Time.deltaTime);

            if (transform.position.x < -15)
            {
                Destroy(gameObject);

            }


        }
        
        
        
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player2")
        {
            Destroy(gameObject);
        
        }

        
    
    }
}
