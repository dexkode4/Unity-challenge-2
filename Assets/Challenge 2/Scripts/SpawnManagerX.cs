using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        Debug.Log("spawnInterval here" + spawnInterval);
    }

    void Update(){
         spawnInterval = Random.Range(3, 5);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        GameObject ballPrefab = ballPrefabs[Random.Range(0, ballPrefabs.Length)];
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefab, spawnPos, ballPrefab.transform.rotation);
    }

}
