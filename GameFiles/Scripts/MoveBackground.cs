using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float speed = 10.0f;
    private int movedir =1;
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
            transform.Translate(Vector2.left * speed * Time.deltaTime * movedir);
            if (transform.position.x < -17.65577F)
            {
                transform.position = new Vector3(17.65577f, transform.position.y, 1);

            }


        }
        
    }
}
