using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour
{
    public Transform cameraPos;

    public GameObject[] obj;
    public float spawnMin = 10f;
    public float spawnMax = 15f;

    private int randSide = 0;

    private int cameraSpawn = 2;
    // Use this for initialization
    void Start()
    {
        Spawn();
    }

    //    void Update()
    //    {
    //        if (cameraPos.position.y % cameraSpawn == 0)
    //        {
    //            Spawn();
    //        }
    //    }

    void Spawn()
    {
        float spawnBounds = GetComponent<MeshCollider>().bounds.size.x / 2;
        float randX = Random.Range(0, spawnBounds);
        randSide = (randSide == 0) ? 1 : 0;
        Debug.Log(randSide);
        Vector3 randXPos = new Vector3(randX - spawnBounds + (spawnBounds * randSide), transform.position.y, transform.position.z);

        Instantiate(obj[Random.Range(0, obj.GetLength(0))], randXPos, Quaternion.identity);
        Invoke("Spawn", 3);//Random.Range (spawnMin, spawnMax);
    }
}
