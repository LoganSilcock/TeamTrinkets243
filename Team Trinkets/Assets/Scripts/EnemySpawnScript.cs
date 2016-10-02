using UnityEngine;
using System.Collections;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject enemy;
    public float spawnMin = 10f;
    public float spawnMax = 20f;

    //private int randSide = 0;

    // Use this for initialization
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        
        Instantiate(enemy, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));

        /**
        Instantiate(enemy, transform.position, Quaternion.identity);

        float spawnBounds = GetComponent<MeshCollider>().bounds.size.x / 2;
        float randX = Random.Range(0, spawnBounds);
        randSide = (randSide == 0) ? 1 : 0;

        Vector3 randXPos = new Vector3(randX / 2 - spawnBounds + (spawnBounds * randSide), transform.position.y, transform.position.z);

        Invoke("Spawn", 1.0f); *///Random.Range (spawnMin, spawnMax);
    }
}