using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    private FarmerController playerController;

    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
        playerController = GameObject.Find("Player").GetComponent<FarmerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        if (playerController.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

        }
    }
}
