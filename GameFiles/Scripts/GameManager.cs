using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;
    public int score;
    public Player player;

    private float startDelay = 1.0f;
    private float repeatInterval = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        score = 0;
        scoreText.text ="Score: " + score;
        
        InvokeRepeating("UpdateScore", startDelay, repeatInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        if (!player.gameOver)
        {
            score += 1;
            scoreText.text = "Score: " + score;


        }
        


    }


    
    
}