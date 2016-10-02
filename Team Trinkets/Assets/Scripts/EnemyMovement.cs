using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    public Transform playerPos;

    private float enemXAdd = 0.0f;
    private float enemYAdd = 0.02f;

    // Use this for initialization
    void Start()
    {
	
    }
	
    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y > playerPos.position.y)
        {
            if (transform.position.x < playerPos.position.x)
            {
                enemXAdd = 0.01f;
            }
            if (transform.position.x > playerPos.position.x)
            {
                enemXAdd = -0.01f;
            }
        }

        transform.position = new Vector3(transform.position.x + enemXAdd, transform.position.y - enemYAdd, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Break();
        }
    }
}
