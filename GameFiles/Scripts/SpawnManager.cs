using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject surface;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject coins;
    private float startDelay = 0.0F;
    private float repeatInterval = 5F;

    private float start = 0.5f;
    private float repeat = 1f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSurfaceAndEnemy", startDelay, repeatInterval);
        InvokeRepeating("SpawnCoins", start, repeat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnSurfaceAndEnemy()
    {
        Vector2 spawnPos1 = new Vector2(20,Random.Range(-5.3f, -4));
        Vector2 spawnPos2 = new Vector2(20, Random.Range(4.5f, 6f));
        Instantiate(surface, spawnPos1, surface.transform.rotation);
        Instantiate(surface, spawnPos2, surface.transform.rotation);
        Instantiate(enemy1, new Vector2(spawnPos1.x , spawnPos1.y + 1.5f),enemy1.transform.rotation);
        Instantiate(enemy2, new Vector2(spawnPos2.x , spawnPos2.y - 1.5f), enemy2.transform.rotation);

        
        
    }

    void SpawnCoins()
    {
        Vector2 coinPos1 = new Vector2(20, Random.Range(-5.3f, -4));
        Vector2 coinPos2 = new Vector2(20, Random.Range(4.5f, 6f));
        Instantiate(coins, new Vector2(coinPos1.x, coinPos1.y + 1.5f), coins.transform.rotation);
        Instantiate(coins, new Vector2(coinPos2.x, coinPos2.y - 1.5f), coins.transform.rotation);

    }
}
