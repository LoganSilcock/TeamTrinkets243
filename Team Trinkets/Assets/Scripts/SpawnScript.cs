using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 10f;
	public float spawnMax = 15f;

	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	void Spawn(){
		Instantiate (obj[Random.Range (0, obj.GetLength(0))], transform.position, Quaternion.identity);
		Invoke ("Spawn", 20);//Random.Range (spawnMin, spawnMax);
	}
}
