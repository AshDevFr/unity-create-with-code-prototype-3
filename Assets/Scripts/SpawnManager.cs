using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnStartDelay = 1.0f;
    public float spawnDelayMin = 1.0f;
    public float spawnDelayMax = 3.0f;

    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        Invoke("SpawnObstacle", spawnStartDelay);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnObstacle()
    {
        if (!playerController.gameOver)
        {
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
        }

        Invoke("SpawnObstacle", Random.Range(spawnDelayMin, spawnDelayMax));
    }
}