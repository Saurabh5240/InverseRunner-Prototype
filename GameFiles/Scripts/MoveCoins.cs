using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCoins : MonoBehaviour
{
    public float speed = 4f;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player1").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.gameOver)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            OffBounds();



        }

    }

    void OffBounds()
    {
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);

        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            Destroy(gameObject);
            


        }


    }
}
