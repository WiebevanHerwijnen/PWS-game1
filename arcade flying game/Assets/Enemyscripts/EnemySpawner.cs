using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
    {
    public GameObject EnemyGO;

    float maxSpawnRateInSeconds = 5f;

	// Use this for initialization
	void Start ()
    {
        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    void SpawnEnemy()
    {
        //this is bottom left
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        //this is top right
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        GameObject anEmeny = (GameObject)Instantiate(EnemyGO);
        anEmeny.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);

        ScheduleNextEnemySpawn();
    }
    void ScheduleNextEnemySpawn()
    {
        float spawnInSeconds;
        if (maxSpawnRateInSeconds > 1f)
        {
            spawnInSeconds = Random.Range(1f, maxSpawnRateInSeconds);

        }
        else
            spawnInSeconds = 1f;
        Invoke ("SpawnEnemy", spawnInSeconds);
    }

    void IncreaseSpawnrate()
    {
        if (maxSpawnRateInSeconds > 1f)
            maxSpawnRateInSeconds--;
        if (maxSpawnRateInSeconds == 1f)
            CancelInvoke("IncreaseSpawnRate");
    }
}
