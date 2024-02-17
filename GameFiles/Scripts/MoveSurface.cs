using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSurface : MonoBehaviour
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

            if (transform.position.x < -20)
            {
                Destroy(gameObject);

            }


        }
        
    }
}
