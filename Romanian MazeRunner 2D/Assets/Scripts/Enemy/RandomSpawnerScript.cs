using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnerScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public Transform playerTransform;
    public float enemyInterval = 10f;

    private IPlayerUtility playerUtility;

    // Start is called before the first frame update
    void Start()
    {
        playerUtility = new PlayerUtility();
        InvokeRepeating("spawnEnemy", 1f, enemyInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private void spawnEnemy()
    {
        int rangeEnemy = Random.Range(0, enemyPrefabs.Length);
        int rangeSpawnPointEnemy = Random.Range(0, spawnPoints.Length);

        bool xd = this.playerUtility.playerIsInFrontOf(spawnPoints[rangeSpawnPointEnemy].position,
            playerTransform.forward, transform);
        
        if (this.playerUtility.playerIsInFrontOf(spawnPoints[rangeSpawnPointEnemy].position, playerTransform.forward, transform) &&
            this.playerUtility.playerIsWithinDistanceFrom(spawnPoints[rangeSpawnPointEnemy].position, playerTransform.position, 30))
        {
            Debug.Log("nice");
            GameObject enemy = Instantiate(enemyPrefabs[rangeEnemy], spawnPoints[rangeSpawnPointEnemy].position, transform.rotation);
        }
    }
}
