using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player2Script : MonoBehaviour
{
    public GameObject[] platforms;
    public float moveSpeed = 0.5f;

    Vector2 dest = Vector2.zero;

    private Vector2 playerPos = new Vector2(GameObject.Find("PlatformCreator").transform.position.x, GameObject.Find("PlatformCreator").transform.position.y);

    void Start()
    {
        dest = transform.position;
    }
	
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 p = Vector2.MoveTowards(transform.position, dest, moveSpeed);
        GetComponent<Rigidbody2D>().MovePosition(p);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            dest = (Vector2)transform.position + Vector2.up;
            //playerPos.y = playerPos.y + moveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            dest = (Vector2)transform.position - Vector2.up;
            //playerPos.y = playerPos.y - moveSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            dest = (Vector2)transform.position + Vector2.right;
            //playerPos.x = playerPos.x + moveSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dest = (Vector2)transform.position - Vector2.right;
            //playerPos.x = playerPos.x - moveSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            
            NewPlatform();
        }
    }

    void NewPlatform()
    {
        Instantiate(platforms[Random.Range(0, platforms.GetLength(0))], dest, Quaternion.identity);

    }
}
