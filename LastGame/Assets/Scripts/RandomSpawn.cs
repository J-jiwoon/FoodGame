using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{    
    public GameObject[] foodPrefab;
    private float spawnRangeX = 109f;
    private float spawnposZ = 0;

    float span = 0.8f;
    float delta = 0;
    
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            Vector3 spawnPos = new Vector3(Random.Range(90, 110), 106, spawnposZ);

            int foodIndex = Random.Range(0, foodPrefab.Length);
            Instantiate(foodPrefab[foodIndex], spawnPos, Quaternion.identity);
        }
    }
}
